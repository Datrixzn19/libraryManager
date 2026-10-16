var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "working");

app.Run(); 