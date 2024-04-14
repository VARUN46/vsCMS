var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.vsCMSBackend_ApiService>("apiservice");

builder.Build().Run();
