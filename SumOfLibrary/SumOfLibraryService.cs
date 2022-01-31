using System;
using System.Linq;

namespace SumOfLibrary
{
    public class SumOfLibraryService : ISumOfLibraryService
    {
        public long Do(int input)
        {
            if (input <= 0)
                throw new Exception("The input must be positive");
            return Enumerable.Range(0, input).Sum(x => (x % 3 == 0 && x % 5 == 0) ? 0 : (x % 3 == 0 || x % 5 == 0) ? x : 0);
        }
    }
}
