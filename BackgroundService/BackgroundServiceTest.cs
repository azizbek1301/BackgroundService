

namespace BackgroundService1
{
    public class BackgroundServiceTest : IHostedService
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

        public Task StartAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
