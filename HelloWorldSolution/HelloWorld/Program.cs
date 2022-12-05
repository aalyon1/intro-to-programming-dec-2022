using HelloWorld;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<DateUtils>();
var app = builder.Build();

//Route Parameter
app.MapGet("/break/{minutes:int}", (int minutes, DateUtils utils) =>
{
    var response = new BreakTimerResponse(
        minutes,
        DateTime.Now,
        utils.TakeABreak(minutes)
        ) ;
    return Results.Ok(response);
});

app.Run();

public record BreakTimerResponse(int Minutes, DateTime StartTime, DateTime EndTime);