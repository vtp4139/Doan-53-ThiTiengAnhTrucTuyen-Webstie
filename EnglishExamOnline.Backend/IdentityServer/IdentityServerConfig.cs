using IdentityServer4;
using IdentityServer4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishExamOnline.Backend.IdentityServer
{
    public class IdentityServerConfig
    {
        public static IEnumerable<IdentityResource> IdentityResources =>
                new List<IdentityResource>
                {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
                };

        public static IEnumerable<ApiScope> ApiScopes =>
             new ApiScope[]
             {
                  new ApiScope("english_exam.api", "English Exam API")
             };

        public static IEnumerable<Client> Clients =>
            new List<Client>
            {
                // machine to machine client
                new Client
                {
                    ClientId = "client",
                    ClientSecrets = { new Secret("secret".Sha256()) },

                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    // scopes that client has access to
                    AllowedScopes = { "english_exam.api" }
                },

                // interactive ASP.NET Core MVC client
                new Client
                {
                    ClientId = "mvc",
                    ClientSecrets = { new Secret("secret".Sha256()) },

                    AllowedGrantTypes = GrantTypes.Code,

                    RedirectUris = { "https://localhost:44340/signin-oidc" },

                    PostLogoutRedirectUris = { "https://localhost:44340/signout-callback-oidc" },

                    AllowedScopes = new List<string>
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        "english_exam.api"
                    },

                     AccessTokenLifetime = 86400,
              },

                new Client
                {
                    ClientId = "swagger",
                    ClientSecrets = { new Secret("secret".Sha256()) },
                    AllowedGrantTypes = GrantTypes.Code,

                    RequireConsent = false,
                    RequirePkce = true,

                    RedirectUris =           { $"https://localhost:44302/swagger/oauth2-redirect.html" },
                    PostLogoutRedirectUris = { $"https://localhost:44302/swagger/oauth2-redirect.html" },
                    AllowedCorsOrigins =     { $"https://localhost:44302" },

                    AllowedScopes = new List<string>
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        "english_exam.api"
                    }
                }
            };
    }
}
