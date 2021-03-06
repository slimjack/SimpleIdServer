﻿// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.
using SimpleIdServer.OpenID.Domains;
using System.Collections.Generic;

namespace SimpleIdServer.OpenID
{
    public static class SIDOpenIdConstants
    {
        public static class EndPoints
        {
            public const string OpenIDConfiguration = ".well-known/openid-configuration";
            public const string UserInfo = "userinfo";
            public const string CheckSession = "check_session";
            public const string EndSession = "end_session";
            public const string EndSessionCallback = "end_session_callback";
        }

        public static class StandardScopes
        {
            public static OpenIdScope Profile = new OpenIdScope
            {
                Name = "profile",
                Claims = new List<string>
                {
                    Jwt.Constants.UserClaims.Name,
                    Jwt.Constants.UserClaims.FamilyName,
                    Jwt.Constants.UserClaims.UniqueName,
                    Jwt.Constants.UserClaims.GivenName,
                    Jwt.Constants.UserClaims.MiddleName,
                    Jwt.Constants.UserClaims.NickName,
                    Jwt.Constants.UserClaims.PreferredUserName,
                    Jwt.Constants.UserClaims.Profile,
                    Jwt.Constants.UserClaims.Picture,
                    Jwt.Constants.UserClaims.WebSite,
                    Jwt.Constants.UserClaims.Gender,
                    Jwt.Constants.UserClaims.BirthDate,
                    Jwt.Constants.UserClaims.ZoneInfo,
                    Jwt.Constants.UserClaims.Locale,
                    Jwt.Constants.UserClaims.UpdatedAt
                }
            };
            public static OpenIdScope Email = new OpenIdScope
            {
                Name = "email",
                Claims = new List<string>
                {
                    Jwt.Constants.UserClaims.Email,
                    Jwt.Constants.UserClaims.EmailVerified
                }
            };
            public static OpenIdScope Address = new OpenIdScope
            {
                Name = "address",
                Claims = new List<string>
                {
                    Jwt.Constants.UserClaims.Address
                }
            };
            public static OpenIdScope Phone = new OpenIdScope
            {
                Name = "phone",
                Claims = new List<string>
                {
                    Jwt.Constants.UserClaims.PhoneNumber,
                    Jwt.Constants.UserClaims.PhoneNumberVerified
                }
            };
            public static OpenIdScope OpenIdScope = new OpenIdScope
            {
                Name = "openid",
                Claims = new List<string>
                {
                    Jwt.Constants.UserClaims.Subject
                }
            };
            public static OpenIdScope OfflineAccessScope = new OpenIdScope
            {
                Name = "offline_access"
            };
        }
    }
}