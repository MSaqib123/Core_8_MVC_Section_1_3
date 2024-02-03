var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//================================================
//============ Section #  HttpContext ============
//================================================

//===== 1. MapGet ======
//map only return values
//app.MapGet("/", () => "Hello World!");

//===== 2. Run , httpContext , async + await =======
//to write code in block ---
//accept httpContext parameter
app.Run(async (HttpContext context) =>
{
    context.Response.StatusCode = 400;
    await context.Response.WriteAsync("Hello");
});

//===== 2. Run , httpContext , async + await =======


app.Run();
