using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RunesAPI.Services;

namespace RunesAPI.Controllers
{
    [Route("/api/medieval-futhork")]
    public class MedievalFuthorkController : Controller
    {

        private readonly IRunesService _runeService;

        public MedievalFuthorkController(IRunesService runeService)
        {
            _runeService = runeService;
        }

        [HttpGet("{content}")]
        public ActionResult<string> Get(string content)
        {
            return _runeService.ToMedievalFuthork(content);
        }
    }
}