using DummyApi.Domain;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseHttpsRedirection();

app.MapGet("/say", () =>
{
    var human = new Human();
    return Results.Ok(human.SaySomething());
});

app.Run();
