using System.Linq;

namespace SequenceAnalysis
{
    public class SequenceAnalysisService : ISequenceAnalysisService
    {
        public string Do(string input)
        {
            if (string.IsNullOrEmpty(input))
                return string.Empty;
            string upperstring= string.Empty;
            foreach(var chr in input)
            {
                if (!char.IsUpper(chr))
                    continue;
                upperstring += chr;
            }
            return new string(upperstring.OrderBy(x => x).ToArray());
        }
    }
}
