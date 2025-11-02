using Microsoft.EntityFrameworkCore;
using WebAPIDemoAdvanced.Data;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

if (builder.Environment.EnvironmentName != "Testing")
    builder.Services.AddDbContext<MyDbContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


app.MapGet("/TestMe", async (int id, MyDbContext context) => {
    var greeting = context.Greetings.FirstOrDefault(x => x.Id == id);
    await Task.Delay(1);
    return Results.Ok(greeting);
})
.WithName("TestMe");

app.Run();

public partial class Program { }
