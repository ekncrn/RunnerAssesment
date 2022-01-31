using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using SequenceAnalysis;
using SumOfLibrary;

namespace RunnerAssesment
{
    class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddLogging();
                    services.AddHostedService<RunnerService>();
                    services.AddTransient<ISequenceAnalysisService, SequenceAnalysisService>();
                    services.AddTransient<ISumOfLibraryService, SumOfLibraryService>();
                })
                .ConfigureLogging(logging =>
                {
                    logging.ClearProviders();
                    logging.AddConsole();
                });
        }
    }
}
