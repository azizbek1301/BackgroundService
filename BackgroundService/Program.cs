using BackgroundService1;

WebApplicationBuilder? builder = WebApplication.CreateBuilder(args);


builder.Services.AddHostedService<BackgroundServiceTest>();

WebApplication? app = builder.Build();




app.Run();

