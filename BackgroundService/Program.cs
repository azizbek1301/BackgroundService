using BackgroundService1;

WebApplicationBuilder? builder = WebApplication.CreateBuilder(args);


builder.Services.AddHostedService<BackgroundServiceTest>();

builder.Services.Configure<HostOptions>(options =>
{
    options.ShutdownTimeout = TimeSpan.FromSeconds(10);
    //options.BackgroundServiceExceptionBehavior = BackgroundServiceExceptionBehavior.Ignore;
});

WebApplication? app = builder.Build();




app.Run();

