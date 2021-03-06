﻿// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.
using Newtonsoft.Json.Linq;
using SimpleIdServer.Scim.Domain;
using SimpleIdServer.Scim.Infrastructure;
using System.Collections.Generic;

namespace SimpleIdServer.Scim.Commands
{
    public class AddRepresentationCommand : ISCIMCommand<SCIMRepresentation>
    {
        public AddRepresentationCommand(string resourceType, ICollection<string> schemaIds, JObject representation)
        {
            ResourceType = resourceType;
            SchemaIds = schemaIds;
            Representation = representation;
        }

        public string ResourceType { get; set; }
        public ICollection<string> SchemaIds { get; set; }
        public JObject Representation { get; }
    }
}
