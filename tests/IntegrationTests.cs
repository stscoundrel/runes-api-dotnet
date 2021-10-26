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
        [InlineData("/api/elder-futhark/lorem-ipsum")]
        public async Task Rune_Endpoints_Return_Success_And_Correct_Content_Type(string url)
        {
            var client = _factory.CreateClient();
            var response = await client.GetAsync(url);

            // Status Code 200-299
            response.EnsureSuccessStatusCode(); 

            // Plain text
            Assert.Equal("text/plain; charset=utf-8",
                response.Content.Headers.ContentType.ToString());
        }

        [Fact]
        public async Task Younger_Futhark_Endpoint_Returns_Correct_Content()
        {
            var url = "/api/younger-futhark/lorem-ipsum";
            var client = _factory.CreateClient();
            var response = await client.GetAsync(url);

            // Expected body content.
            Assert.Equal("ᛚᚢᚱᛁᛘ-ᛁᛒᛋᚢᛘ",
                response.Content.ReadAsStringAsync().Result);
        }

        [Fact]
        public async Task Elder_Futhark_Endpoint_Returns_Correct_Content()
        {
            var url = "/api/elder-futhark/lorem-ipsum";
            var client = _factory.CreateClient();
            var response = await client.GetAsync(url);

            // Expected body content.
            Assert.Equal("ᛚᛟᚱᛖᛗ-ᛁᛈᛋᚢᛗ",
                response.Content.ReadAsStringAsync().Result);
        }
    }
    #endregion
}