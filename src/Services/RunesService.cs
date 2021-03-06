using Riimut;

using RunesAPI.Services;

namespace RunesAPI.Services
{
    public class RunesService : IRunesService
    {

        public string ToYoungerFuthark(string content) => YoungerFuthark.LettersToRunes(content);
        public string ToElderFuthark(string content) => ElderFuthark.LettersToRunes(content);
        public string ToMedievalFuthork(string content) => MedievalFuthork.LettersToRunes(content);
        public string ToFuthorc(string content) => Futhorc.LettersToRunes(content);
    }
}