var builder = WebApplication.CreateBuilder(args);

//Add services to your application for dependency injection

var app = builder.Build();

//Configure the HTTP request Pipeline

app.Run();
