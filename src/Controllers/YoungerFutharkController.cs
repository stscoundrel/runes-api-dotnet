using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RunesAPI.Services;

namespace RunesAPI.Controllers
{
    [Route("/api/younger-futhark")]
    public class YoungerFutharkController : Controller
    {

        private readonly IRunesService _runeService;

        public YoungerFutharkController(IRunesService runeService)
        {
            _runeService = runeService;
        }

        [HttpGet("{content}")]
        public ActionResult<string> Get(string content)
        {
            return _runeService.ToYoungerFuthark(content);
        }
    }
}