using Optivem.Platform.Test.Web.AspNetCore.Common;
using System;
using System.Threading.Tasks;
using Xunit;

namespace Optivem.Platform.Test.Web.AspNetCore.Rest
{
    public class ValuesControllerIntegrationTest : RestTestServerFixtureTest
    {
        public ValuesControllerIntegrationTest(RestTestServerFixture testServerFixture) 
            : base(testServerFixture)
        {
        }

        [Fact]
        public async Task TestGetAsync()
        {
            var response = await TestServerFixture.HttpClient.GetAsync("api/values");
            Assert.True(response.IsSuccessStatusCode);
        }
    }
}
