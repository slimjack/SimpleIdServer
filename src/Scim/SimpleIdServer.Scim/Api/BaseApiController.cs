﻿// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json.Linq;
using SimpleIdServer.Scim.Commands;
using SimpleIdServer.Scim.Commands.Handlers;
using SimpleIdServer.Scim.Domain;
using SimpleIdServer.Scim.DTOs;
using SimpleIdServer.Scim.Exceptions;
using SimpleIdServer.Scim.Extensions;
using SimpleIdServer.Scim.Helpers;
using SimpleIdServer.Scim.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace SimpleIdServer.Scim.Api
{
    public class BaseApiController : Controller
    {
        private readonly string _scimEndpoint;
        private readonly ICollection<SCIMSchema> _schemas;
        private readonly IAddRepresentationCommandHandler _addRepresentationCommandHandler;
        private readonly IDeleteRepresentationCommandHandler _deleteRepresentationCommandHandler;
        private readonly IReplaceRepresentationCommandHandler _replaceRepresentationCommandHandler;
        private readonly IPatchRepresentationCommandHandler _patchRepresentationCommandHandler;
        private readonly ISCIMRepresentationQueryRepository _scimRepresentationQueryRepository;
        private readonly SCIMHostOptions _options;

        public BaseApiController(string scimEndpoint, ICollection<SCIMSchema> schemas, IAddRepresentationCommandHandler addRepresentationCommandHandler, IDeleteRepresentationCommandHandler deleteRepresentationCommandHandler, IReplaceRepresentationCommandHandler replaceRepresentationCommandHandler, IPatchRepresentationCommandHandler patchRepresentationCommandHandler, ISCIMRepresentationQueryRepository scimRepresentationQueryRepository, IOptionsMonitor<SCIMHostOptions> options)
        {
            _scimEndpoint = scimEndpoint;
            _schemas = schemas;
            _addRepresentationCommandHandler = addRepresentationCommandHandler;
            _deleteRepresentationCommandHandler = deleteRepresentationCommandHandler;
            _replaceRepresentationCommandHandler = replaceRepresentationCommandHandler;
            _patchRepresentationCommandHandler = patchRepresentationCommandHandler;
            _scimRepresentationQueryRepository = scimRepresentationQueryRepository;
            _options = options.CurrentValue;
        }

        [HttpGet]
        [Authorize("QueryScimResource")]
        public async Task<IActionResult> Get()
        {
            var searchRequest = SearchSCIMResourceParameter.Create(Request.Query);
            try
            { 
                if (searchRequest.Count > _options.MaxResults)
                {
                    searchRequest.Count = _options.MaxResults;
                }

                var result = await _scimRepresentationQueryRepository.FindSCIMRepresentations(new SearchSCIMRepresentationsParameter(_scimEndpoint, searchRequest.StartIndex, searchRequest.Count, searchRequest.SortBy, searchRequest.SortOrder, SCIMFilterParser.Parse(searchRequest.Filter, _schemas)));
                var jObj = new JObject
                {
                    { SCIMConstants.StandardSCIMRepresentationAttributes.Schemas, new JArray(new [] { SCIMConstants.StandardSchemas.ListResponseSchemas.Id } ) },
                    { SCIMConstants.StandardSCIMRepresentationAttributes.TotalResults, result.TotalResults },
                    { SCIMConstants.StandardSCIMRepresentationAttributes.ItemsPerPage, searchRequest.Count },
                    { SCIMConstants.StandardSCIMRepresentationAttributes.StartIndex, searchRequest.StartIndex }
                };
                var resources = new JArray();
                foreach(var record in result.Content)
                {
                    JObject newJObj = null;
                    var location = $"{Request.GetAbsoluteUriWithVirtualPath()}/{_scimEndpoint}/{record.Id}";
                    if (searchRequest.Attributes.Any())
                    {
                        newJObj = record.ToResponseWithIncludedAttributes(searchRequest.Attributes.Select(a => SCIMFilterParser.Parse(a, _schemas)).ToList());
                    }
                    else if (searchRequest.ExcludedAttributes.Any())
                    {
                        newJObj = record.ToResponseWithExcludedAttributes(searchRequest.ExcludedAttributes.Select(a => SCIMFilterParser.Parse(a, _schemas)).ToList(), location);
                    }
                    else
                    {
                        newJObj = record.ToResponse(location, true);
                    }

                    resources.Add(newJObj);
                }

                jObj.Add(SCIMConstants.StandardSCIMRepresentationAttributes.Resources, resources);
                return new ContentResult
                {
                    StatusCode = (int)HttpStatusCode.OK,
                    Content = jObj.ToString(),
                    ContentType = SCIMConstants.STANDARD_SCIM_CONTENT_TYPE
                };
            }
            catch(SCIMFilterException ex)
            {
                return this.BuildError(HttpStatusCode.BadRequest, ex.Message, "invalidFilter");
            }
        }

        [HttpGet("{id}")]
        [Authorize("QueryScimResource")]
        public Task<IActionResult> Get(string id)
        {
            return InternalGet(id);
        }

        [HttpGet("Me")]
        [Authorize("UserAuthenticated")]
        public Task<IActionResult> GetMe(string id)
        {
            return ExecuteActionIfAuthenticated(() =>
            {
                return InternalGet(id);
            });
        }

        [HttpPost]
        [Authorize("AddScimResource")]
        public Task<IActionResult> Add([FromBody] JObject jobj)
        {
            return InternalAdd(jobj);
        }

        [HttpPost("Me")]
        [Authorize("UserAuthenticated")]
        public Task<IActionResult> AddMe([FromBody] JObject jObj)
        {
            return ExecuteActionIfAuthenticated(() =>
            {
                return InternalAdd(jObj);
            });
        }

        [HttpDelete("{id}")]
        [Authorize("DeleteScimResource")]
        public Task<IActionResult> Delete(string id)
        {
            return InternalDelete(id);
        }

        [HttpDelete("Me/{id}")]
        [Authorize("UserAuthenticated")]
        public Task<IActionResult> DeleteMe(string id)
        {
            return ExecuteActionIfAuthenticated(() =>
            {
                return InternalDelete(id);
            });
        }

        [HttpPut("{id}")]
        [Authorize("UpdateScimResource")]
        public Task<IActionResult> Update(string id, [FromBody] JObject jObj)
        {
            return InternalUpdate(id, jObj);
        }

        [HttpPut("Me/{id}")]
        [Authorize("UserAuthenticated")]
        public Task<IActionResult> UpdateMe(string id, [FromBody] JObject jObj)
        {
            return ExecuteActionIfAuthenticated(() =>
            {
                return InternalUpdate(id, jObj);
            });
        }

        [HttpPatch("{id}")]
        [Authorize("UpdateScimResource")]
        public Task<IActionResult> Patch(string id, [FromBody] JObject jObj)
        {
            return InternalPatch(id, jObj);
        }

        [HttpPatch("Me/{id}")]
        [Authorize("UserAuthenticated")]
        public Task<IActionResult> PatchMe(string id, [FromBody] JObject jObj)
        {
            return ExecuteActionIfAuthenticated(() =>
            {
                return InternalPatch(id, jObj);
            });
        }

        private async Task<IActionResult> InternalGet(string id)
        {
            var representation = await _scimRepresentationQueryRepository.FindSCIMRepresentationById(id, _scimEndpoint);
            if (representation == null)
            {
                return this.BuildError(HttpStatusCode.NotFound, $"Resource {id} not found.");
            }

            return BuildHTTPResult(representation, HttpStatusCode.OK, true);
        }

        private async Task<IActionResult> InternalAdd([FromBody] JObject jobj)
        {
            try
            {
                var command = new AddRepresentationCommand(_scimEndpoint, _schemas.Select(s => s.Id).ToList(), jobj);
                var scimRepresentation = await _addRepresentationCommandHandler.Handle(command);
                return BuildHTTPResult(scimRepresentation, HttpStatusCode.Created, false);
            }
            catch (SCIMBadRequestException)
            {
                return this.BuildError(HttpStatusCode.BadRequest, "Request is unparsable, syntactically incorrect, or violates schema.", "invalidSyntax");
            }
            catch (SCIMUniquenessAttributeException)
            {
                return this.BuildError(HttpStatusCode.Conflict, "One or more of the attribute values are already in use or are reserved.", "uniqueness");
            }
        }

        private async Task<IActionResult> InternalDelete(string id)
        {
            try
            {
                await _deleteRepresentationCommandHandler.Handle(new DeleteRepresentationCommand(id, _scimEndpoint));
                return new StatusCodeResult((int)HttpStatusCode.NoContent);
            }
            catch (SCIMNotFoundException)
            {
                return this.BuildError(HttpStatusCode.NotFound, $"Resource {id} not found.");
            }
        }

        private async Task<IActionResult> InternalUpdate(string id, JObject jObj)
        {
            try
            {
                var newRepresentation = await _replaceRepresentationCommandHandler.Handle(new ReplaceRepresentationCommand(id, _schemas.Select(s => s.Id).ToList(), jObj));
                return BuildHTTPResult(newRepresentation, HttpStatusCode.OK, false);
            }
            catch (SCIMBadRequestException)
            {
                return this.BuildError(HttpStatusCode.BadRequest, "Request is unparsable, syntactically incorrect, or violates schema.", "invalidSyntax");
            }
            catch(SCIMImmutableAttributeException)
            {
                return this.BuildError(HttpStatusCode.BadRequest, "The attempted modification is not compatible with the target attribute's mutability or current state (e.g., modification of an \"immutable\" attribute with an existing value).", "mutability");
            }
            catch(SCIMNotFoundException)
            {
                return this.BuildError(HttpStatusCode.NotFound, "Resource does not exist", "notFound");
            }
        }

        private async Task<IActionResult> InternalPatch(string id, JObject jObj)
        {
            try
            {
                var newRepresentation = await _patchRepresentationCommandHandler.Handle(new PatchRepresentationCommand(id, jObj));
                return BuildHTTPResult(newRepresentation, HttpStatusCode.OK, false);
            }
            catch (SCIMBadRequestException)
            {
                return this.BuildError(HttpStatusCode.BadRequest, "Request is unparsable, syntactically incorrect, or violates schema.", "invalidSyntax");
            }
            catch (SCIMNotFoundException)
            {
                return this.BuildError(HttpStatusCode.NotFound, "Resource does not exist", "notFound");
            }
        }

        private async Task<IActionResult> ExecuteActionIfAuthenticated(Func<Task<IActionResult>> callback)
        {
            var user = User.Claims.FirstOrDefault(c => c.Type == _options.SCIMIdClaimName);
            if (user == null)
            {
                return this.BuildError(HttpStatusCode.BadRequest, $"{_options.SCIMIdClaimName} claim cannot be retrieved", "invalidSyntax");
            }

            return await callback();
        }

        private IActionResult BuildHTTPResult(SCIMRepresentation representation, HttpStatusCode status, bool isGetRequest)
        {
            var location = $"{Request.GetAbsoluteUriWithVirtualPath()}/{_scimEndpoint}/{representation.Id}";
            HttpContext.Response.Headers.Add("Location", location);
            HttpContext.Response.Headers.Add("ETag", representation.Version);
            return new ContentResult
            {
                StatusCode = (int)status,
                Content = representation.ToResponse(location, isGetRequest).ToString(),
                ContentType = SCIMConstants.STANDARD_SCIM_CONTENT_TYPE
            };
        }
    }
}
