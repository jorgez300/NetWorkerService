using Workers;

namespace WorkerServiceConsole
{
    public class Worker : BackgroundService
    {
        LogWorker _logWorker;
        FileWorker _fileWorker;

        public Worker(LogWorker testWorker, FileWorker fileWorker)
        {
            _logWorker = testWorker;
            _fileWorker = fileWorker;
        }
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logWorker.Execute();
                _fileWorker.Execute();
                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}
