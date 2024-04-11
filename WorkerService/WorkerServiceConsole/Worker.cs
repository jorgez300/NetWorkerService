using Workers;

namespace WorkerServiceConsole
{
    public class Worker : BackgroundService
    {
        TestWorker _testWorker;
        public Worker(TestWorker testWorker)
        {
            _testWorker = testWorker;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _testWorker.Log();
                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}
