﻿using IdentityModel;
using IdentityServer4.Models;
using IdentityServer4.Test;
using System.Collections.Generic;
using System.Security.Claims;

namespace Com.DanLiris.Service.Auth.Lib.Authentication
{
    public class Config
    {
        public static string Authority;
        public static string ClientId;
        public static string Secret;

        public static IEnumerable<IdentityResource> GetIdentityResources()
        {
            return new List<IdentityResource>
            {
                new IdentityResources.OpenId()
            };
        }

        public static IEnumerable<ApiResource> GetApiResources()
        {
            return new List<ApiResource>
            {
                new ApiResource("com.danliris.service", "Danliris Web Service", new[] { JwtClaimTypes.Name })
            };
        }

        public static IEnumerable<Client> GetClients()
        {
            return new List<Client>
            {
                new Client
                {
                    ClientId = ClientId,
                    AllowedGrantTypes = GrantTypes.ResourceOwnerPassword,
                    ClientSecrets =
                    {
                        new Secret(Secret.Sha256())
                    },
                    AllowedScopes = { "com.danliris.service" },
                    AccessTokenLifetime = 3600 * 24 * 10,
                    IdentityTokenLifetime = 3600 * 24 * 10
                }
            };
        }

        public static List<TestUser> GetTestUsers()
        {
            return new List<TestUser>
            {
                new TestUser
                {
                    SubjectId = "Test",
                    Username = "Test",
                    Password = "Test".Sha256(),
                    Claims = new List<Claim>
                    {
                        new Claim("name", "Test"),
                        new Claim("username", "Test"),
                        new Claim("profile", "{}"),
                        new Claim("permission", "{}")
                    }
                }
            };
        }
    }
}
