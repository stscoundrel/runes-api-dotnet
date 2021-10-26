using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RunesAPI.Services;

namespace RunesAPI.Controllers
{
    [Route("/api/elder-futhark")]
    public class ElderFutharkController : Controller
    {

        private readonly IRunesService _runeService;

        public ElderFutharkController(IRunesService runeService)
        {
            _runeService = runeService;
        }

        [HttpGet("{content}")]
        public ActionResult<string> Get(string content)
        {
            return _runeService.ToElderFuthark(content);
        }
    }
}