using Workers;

namespace WorkerService
{
    public class Worker : BackgroundService
    {
        TestWorker _testWorker;
        DateTime ahora = DateTime.Now;
        DateTime luego = DateTime.Now.AddSeconds(10);
        public Worker(TestWorker testWorker)
        {
            _testWorker = testWorker;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {

                ahora = DateTime.Now;
                if (ahora >= luego)
                {
                    luego = ahora.AddSeconds(10);
                    _testWorker.Log();
                }

                await Task.Delay(100, stoppingToken);
            }
        }
    }
}
