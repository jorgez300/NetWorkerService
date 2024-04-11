using Workers;
using WorkerServiceConsole;

var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddHostedService<Worker>();

builder.Services.AddSingleton<TestWorker>();

var host = builder.Build();
host.Run();
