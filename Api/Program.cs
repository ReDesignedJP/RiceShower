using System.Net;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Serialization;
using Shared.Response;

var builder = WebApplication.CreateBuilder(args);
var conf = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json").Build();
builder.Logging.ClearProviders();
builder.Logging.AddConsole();
builder.WebHost.UseUrls(conf.GetValue<string>("Host"));
builder.Services.AddControllers().AddJsonOptions(x =>
{
    x.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
});
builder.Services.Configure<ApiBehaviorOptions>(options =>
{
    options.SuppressModelStateInvalidFilter = true;
});

var app = builder.Build();

app.MapControllers();
#if DEBUG
    app.UseCors(x =>
    {
        x.AllowAnyOrigin();
        x.AllowAnyHeader();
        x.AllowAnyMethod();
    });
#endif

app.UseStatusCodePages(async (ctx) =>
{
    var res = new GeneralResponseModel{Code=((HttpStatusCode)ctx.HttpContext.Response.StatusCode).ToString(), Success = false};
    await ctx.HttpContext.Response.WriteAsJsonAsync(res, new JsonSerializerOptions{DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull});
});
app.Run();