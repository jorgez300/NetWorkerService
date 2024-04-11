using Workers;
using WorkerServiceConsole;

var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddHostedService<Worker>();

builder.Services.AddSingleton<LogWorker>();

var host = builder.Build();
host.Run();
