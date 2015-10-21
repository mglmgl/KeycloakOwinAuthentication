﻿namespace Owin.Security.Keycloak
{
    public static class Constants
    {
        public const string BearerTokenHeader = "Authorization";

        public static class ClaimTypes
        {
            public const string IdToken = "id_token";
            public const string AccessToken = "access_token";
            public const string RefreshToken = "refresh_token";
            public const string AccessTokenExpiration = "access_token_expiration";
            public const string RefreshTokenExpiration = "refresh_token_expiration";
            public const string Version = "keycloak_auth_version";
            public const string AuthenticationType = "keycloak_auth_type";
            public const string Audience = "audience";
            public const string SubjectId = "subject";
            public const string IssuedAt = "issued_at";
            public const string Issuer = "issuer";
        }

        internal static class OpenIdConnectParameterNames
        {
            public const string RefreshToken = "refresh_token";
        }

        internal static class KeycloakParameters
        {
            public const string IdpHint = "kc_idp_hint";
        }

        internal static class CacheTypes
        {
            public const string AuthenticationProperties = "authProperties";
        }
    }
}