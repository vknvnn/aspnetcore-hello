using IdentityServer4.Models;
using System.Collections.Generic;

namespace identity_server_1
{
    public class Config
    {
        //Define the Api Resources
        public static IEnumerable<ApiResource> GetApiResources()
        {
            return new List<ApiResource>
            {
                new ApiResource("api1", "The API 1")
            };
        }

        //Define the Client that can access api1
        public static IEnumerable<Client> GetClients()
        {
            return new List<Client>
            {
                new Client
                {                    
                    //only use the clientid/secret for authentication
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    //define client id
                    ClientId = "client1",
                    //define secret
                    ClientSecrets =
                    {
                        new Secret("secret1".Sha256())
                    },
                    //scope that client has access to
                    AllowedScopes = { "api1" }
                }
            };
        }

    }
}
