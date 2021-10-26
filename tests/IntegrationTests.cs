using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace RunesAPITests
{
    #region snippet1
    public class IntegrationTests
        : IClassFixture<WebApplicationFactory<RunesAPI.Startup>>
    {
        private readonly WebApplicationFactory<RunesAPI.Startup> _factory;

        public IntegrationTests(WebApplicationFactory<RunesAPI.Startup> factory)
        {
            _factory = factory;
        }

        [Theory]
        [InlineData("/api/younger-futhark/lorem-ipsum")]
        public async Task Younger_Futhark_Endpoint_Returns_Success_And_Correct_Content_Type(string url)
        {
            var client = _factory.CreateClient();
            var response = await client.GetAsync(url);

            // Status Code 200-299
            response.EnsureSuccessStatusCode(); 

            // Plain text
            Assert.Equal("text/plain; charset=utf-8",
                response.Content.Headers.ContentType.ToString());

            // Expected body content.
            Assert.Equal("ᛚᚢᚱᛁᛘ-ᛁᛒᛋᚢᛘ",
                response.Content.ReadAsStringAsync().Result);
        }
    }
    #endregion
}