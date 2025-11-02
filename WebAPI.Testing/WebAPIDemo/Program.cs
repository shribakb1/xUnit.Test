var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/TestMe", async (int id) => {
    await Task.Delay(1);
    return Results.Ok(new { id = id, message = "Hello World!" });
})
.WithName("TestMe");

app.Run();


public partial class Program { }