// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityServer4;
using IdentityServer4.Models;
using System.Collections.Generic;

namespace IdSrvInMem
{
    public static class Config
    {
        public static IEnumerable<IdentityResource> Ids =>
            new IdentityResource[]
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
               
            };


        public static IEnumerable<ApiResource> Apis =>
            new ApiResource[]
            {

                new ApiResource("NotaFiscal", "MinhaAPIdeNotaFiscal")
                // new ApiResource
                //{
                //    Name = "NotaFiscal", // API que eu desejo proteger no meu Identity Server
                //    Description = "Api de Notas Fiscais",
                //    Scopes = new []{
                //        new Scope("NotaFiscal.fullaccess"),
                //        new Scope("NotaFiscal.readonly")
                //    }
                //}
            };


        public static IEnumerable<Client> Clients =>
            new Client[]
            {

                 new Client
                {
                    ClientId = "mvc.implicit",
                    ClientName = "Minha Aplicação Web MVC", 
                    AllowedGrantTypes = GrantTypes.Implicit, // Token Implicit, provavelmente server to server mudar aqui
                    AllowAccessTokensViaBrowser = true,   
                    RedirectUris = { "http://localhost:27003/signin-oidc" },
                    AllowedScopes = {"NotaFiscal", "openid", "profile"},
            },


                //// client credentials flow client
                //new Client
                //{
                //    ClientId = "client",
                //    ClientName = "Client Credentials Client",

                //    AllowedGrantTypes = GrantTypes.ClientCredentials,
                //    ClientSecrets = { new Secret("511536EF-F270-4058-80CA-1C89C192F69A".Sha256()) },

                //    AllowedScopes = { "api1", "NotaFiscal" }
                //},



                //// MVC client using code flow + pkce
                //new Client
                //{
                //    ClientId = "MvcClient",
                //    ClientName = "MvcClient",

                //    AllowedGrantTypes = GrantTypes.CodeAndClientCredentials,
                //    RequirePkce = true,
                //    ClientSecrets = { new Secret("49C1A7E1-0C79-4A89-A3D6-A37998FB86B0".Sha256()) },

                //    RedirectUris = { "http://localhost:5003/signin-oidc" },
                //    FrontChannelLogoutUri = "http://localhost:5003/signout-oidc",
                //    PostLogoutRedirectUris = { "http://localhost:5003/signout-callback-oidc" },
                //    AllowedScopes = { "openid", "profile", "api1","NotaFiscal", IdentityServerConstants.StandardScopes.OpenId,
                //        IdentityServerConstants.StandardScopes.Profile }
                //},

                //// SPA client using code flow + pkce
                //new Client
                //{
                //    ClientId = "spa",
                //    ClientName = "SPA Client",
                //    ClientUri = "http://identityserver.io",

                //    AllowedGrantTypes = GrantTypes.Code,
                //    RequirePkce = true,
                //    RequireClientSecret = false,

                //    RedirectUris =
                //    {
                //        "http://localhost:5002/index.html",
                //        "http://localhost:5002/callback.html",
                //        "http://localhost:5002/silent.html",
                //        "http://localhost:5002/popup.html",
                //    },

                //    PostLogoutRedirectUris = { "http://localhost:5002/index.html" },
                //    AllowedCorsOrigins = { "http://localhost:5002" },

                //    AllowedScopes = { "openid", "profile", "api1", "NotaFiscal" }
                //}
            };
    }
}