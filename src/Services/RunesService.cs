using Riimut;

using RunesAPI.Services;

namespace RunesAPI.Services
{
    public class RunesService : IRunesService
    {

        public string ToYoungerFuthark(string content) => YoungerFuthark.LettersToRunes(content);
    }
}