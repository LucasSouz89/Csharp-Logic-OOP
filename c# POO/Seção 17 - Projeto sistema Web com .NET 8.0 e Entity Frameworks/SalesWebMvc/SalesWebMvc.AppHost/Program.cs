var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.SalesWebMvc>("saleswebmvc");

builder.Build().Run();
