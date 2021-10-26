namespace RunesAPI.Services
{
    public interface IRunesService
    {

        public string ToYoungerFuthark(string content);
        public string ToElderFuthark(string content);
        public string ToMedievalFuthork(string content);
    }
}