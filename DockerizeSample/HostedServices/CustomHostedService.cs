namespace DockerizeSample.HostedServices;

public class CustomHostedService : BackgroundService
{
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            await Task.Yield();

            var key = Console.ReadKey(true);

            Console.WriteLine($"You Entered The {key.KeyChar} Key.");
        }
    }
}