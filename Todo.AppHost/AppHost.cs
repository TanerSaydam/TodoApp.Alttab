var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.TodoApp_MVC>("todoapp-mvc");

builder.Build().Run();
