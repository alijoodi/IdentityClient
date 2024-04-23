using IdentityServer4.Models;
using IdentityServer4.Test;

namespace BankOfDotNet.IdentityServer
{
    public class Config
    {
        public static IEnumerable<ApiResource> GetAllApiResources()
        {
            return new List<ApiResource>() { new ApiResource("BankOfDotNetApi") };
        }

        public static IEnumerable<Client> GetClients()
        {
            return new List<Client>()
            {
                new Client
                {
                    ClientId="postman",
                    AllowedGrantTypes=GrantTypes.ClientCredentials,
                    ClientSecrets={new Secret("secret".Sha256()) },
                    AllowedScopes={ "BankOfDotNetApi" }
                },
                //ResourceOwner Client
                new Client
                {
                    ClientId="postmanResourceOwnerPassword",
                    AllowedGrantTypes=GrantTypes.ResourceOwnerPassword,
                    ClientSecrets={new Secret("secret".Sha256()) },
                    AllowedScopes={ "BankOfDotNetApi" }
                },
            };
        }

        public static List<TestUser> GetTestUsers()
        {
            return new List<TestUser>() {
                new TestUser
                {
                SubjectId = "1",
                Username = "ali",
                Password = "password"
                },
                new TestUser
                {
                SubjectId = "2",
                Username = "saeed",
                Password = "password"
                },

            };
        }

    }
}
