using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RunesAPI.Services;

namespace RunesAPI.Controllers
{
    [Route("/api/futhorc")]
    public class FuthorcController : Controller
    {

        private readonly IRunesService _runeService;

        public FuthorcController(IRunesService runeService)
        {
            _runeService = runeService;
        }

        [HttpGet("{content}")]
        public ActionResult<string> Get(string content)
        {
            return _runeService.ToFuthorc(content);
        }
    }
}