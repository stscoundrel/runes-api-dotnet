using System;
using System.Runtime.CompilerServices;
using Xunit;
using Microsoft.AspNetCore.Mvc;
using RunesAPI.Controllers;
using RunesAPI.Services;

namespace RunesAPITests.Controllers
{
    public class FuthorcControllerTest
    {
        [Fact]
        public void Endpoint_Returns_Given_Content_In_Futhorc_Runes()
        {
            var controller = new FuthorcController(new RunesService());

            string content = "lorem ipsum";
            string expected = "ᛚᚩᚱᛖᛗ:ᛁᛈᛋᚢᛗ";
            var result = controller.Get(content);
            var value = (OkObjectResult)result.Result;

            Assert.Equal(expected, result.Value);
        }
    }
}
