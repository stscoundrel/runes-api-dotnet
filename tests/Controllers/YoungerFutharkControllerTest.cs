using System;
using System.Runtime.CompilerServices;
using Xunit;
using Microsoft.AspNetCore.Mvc;
using RunesAPI.Controllers;
using RunesAPI.Services;

namespace RunesAPITests.Controllers
{
    public class YoungerFutharkControllerTest
    {
        [Fact]
        public void Endpoint_Returns_Given_Content_In_Younger_Futhark_Runes()
        {
            var controller = new YoungerFutharkController(new RunesService());

            string content = "lorem ipsum";
            string expected = "ᛚᚢᚱᛁᛘ:ᛁᛒᛋᚢᛘ";
            var result = controller.Get(content);
            var value = (OkObjectResult)result.Result;

            Assert.Equal(expected, result.Value);
        }
    }
}
