var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.SistemaInventario>("sistemainventario");

builder.Build().Run();
