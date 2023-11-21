

namespace BackgroundService1
{
    public class BackgroundServiceTest //: IHostedService
    {

        // BAckgroundService

        //protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        //{
        //    PeriodicTimer? period=new PeriodicTimer(TimeSpan.FromSeconds(2));

        //    while (await period.WaitForNextTickAsync(stoppingToken))
        //    {
        //        Console.WriteLine("Dastur ishga tushdii");

        //    }

        //}


        // IHosted Services


        private readonly ILogger<BackgroundServiceTest> _logger;

        public BackgroundServiceTest(ILogger<BackgroundServiceTest> logger)
        {
            _logger = logger;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("StartAsync");
            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("StopAsync");
            return Task.CompletedTask;
        }
    }
}
