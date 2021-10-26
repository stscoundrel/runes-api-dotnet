using System;
using System.Runtime.CompilerServices;
using Xunit;
using Microsoft.AspNetCore.Mvc;
using RunesAPI.Controllers;
using RunesAPI.Services;

namespace RunesAPITests.Controllers
{
    public class MedievalFuthorkControllerTest
    {
        [Fact]
        public void Endpoint_Returns_Given_Content_In_Medieval_Futhork_Runes()
        {
            var controller = new MedievalFuthorkController(new RunesService());

            string content = "lorem ipsum";
            string expected = "ᛚᚮᚱᚽᛘ:ᛁᛕᛋᚢᛘ";
            var result = controller.Get(content);
            var value = (OkObjectResult)result.Result;

            Assert.Equal(expected, result.Value);
        }
    }
}
