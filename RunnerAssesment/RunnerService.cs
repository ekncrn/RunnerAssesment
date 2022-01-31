using Microsoft.Extensions.Hosting;
using SequenceAnalysis;
using SumOfLibrary;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace RunnerAssesment
{
    public class RunnerService : BackgroundService
    {
        private ISumOfLibraryService _sumOfLibrary;
        private ISequenceAnalysisService _sequenceAnalysis;
        public RunnerService(ISumOfLibraryService sumOfLibrary, ISequenceAnalysisService sequenceAnalysisService)
        {
            _sumOfLibrary = sumOfLibrary;
            _sequenceAnalysis = sequenceAnalysisService;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            bool stop = false;
            while (!stop)
            {
                stop = RunProblems();
                await Task.Delay(10000, stoppingToken);
            }
        }
        public bool RunProblems()
        {
            bool stop = false;
            ProblemsEnum problem = InputHelper.GetIntroductionMessage();
            Console.WriteLine();
            switch (problem)
            {
                case ProblemsEnum.SequenceAnalysis:
                    var str = InputHelper.GetStringForSequenceAnalysis();
                    var result = _sequenceAnalysis.Do(str);
                    Console.WriteLine();
                    Console.WriteLine($"Answer:'{result}' Input:'{str}'");
                    break;

                case ProblemsEnum.SumOfMultiple:
                    var limit = InputHelper.GetLimitForSumOfMultiple();
                    if (limit > 0)
                    {
                        long sum = _sumOfLibrary.Do(limit);
                        Console.WriteLine($"Answer:'{sum}' Limit:'{limit}'");
                    }
                    break;
                case ProblemsEnum.None:
                    stop = true;
                    break;
                default:
                    break;
            }
            return stop;
        }
    }
}
