var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseRouting();

app.MapGet("/hi", () => "Hello Ankan!");

app.UseEndpoints(endpoints =>
{
    endpoints.MapGet("/home", async (context) =>
    {
        await context.Response.WriteAsync("This is Home page...");
    });

    endpoints.Map("/me", async (context) =>
    {
        await context.Response.WriteAsync("My name is Ankan");
    });
});


app.Run( async(HttpContext context) =>
{
    await context.Response.WriteAsync("Page Not Found...");
});

app.Run();
