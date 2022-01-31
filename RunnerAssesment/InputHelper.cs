using System;

namespace RunnerAssesment
{
    public static class InputHelper
    {
        public static ProblemsEnum GetIntroductionMessage()
        {
            Console.WriteLine("Please enter the number of the problem you want to select:");
            Console.WriteLine("SumOfMultiple -> 1");
            Console.WriteLine("SequenceAnalysis -> 2");
            Console.WriteLine("Exit -> -1");
            var number = Console.ReadLine();
            if (int.TryParse(number, out int result))
            {
                return (ProblemsEnum)result;
            }
            else
                Console.WriteLine("You entered wrong number.");
            return ProblemsEnum.None;
        }

        public static int GetLimitForSumOfMultiple()
        {
            Console.WriteLine("SUM OF MULTIPLE");
            Console.Write("Please enter a limit ( Exit -> -1):");
            var number = Console.ReadLine();

            if (int.TryParse(number, out int result))
            {               
                return result;
            }
            else
                Console.WriteLine("You entered wrong number.");
            return -1;
        }

        public static string GetStringForSequenceAnalysis()
        {
            Console.WriteLine("SEQUENCE ANALYSIS");
            Console.Write("Please enter a string ( Exit -> -1):");
            var result = Console.ReadLine();
            return result;
        }
    }

    public enum ProblemsEnum
    {
        None = 0,
        SumOfMultiple = 1,
        SequenceAnalysis = 2
    }
}
