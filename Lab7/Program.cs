using Lab7.Services;
using Lab7.Services.Implementations;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;

services.AddControllers();
services
    .AddEndpointsApiExplorer()
    .AddSwaggerGen();

services.AddSingleton<IHistoryService, HistoryService>();
services.AddSingleton<IProductService, ProductService>();
services.AddSingleton<IUserService, UserService>();


var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app
        .UseSwagger()
        .UseSwaggerUI();
}

app.MapControllers();
app.Run();
