var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World! Value: {configuration.GetSection("test”).Value}");

app.Run();

