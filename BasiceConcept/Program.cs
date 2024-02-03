using Microsoft.AspNetCore.Http;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//================================================
//============ Section #  HttpContext ============
//================================================
//Divided into 3 section
//1. General (status header)
//2. Response Header
//3. Request Headers

//===== MapGet ======
#region MapGet
//map only return values
//app.MapGet("/", () => "Hello World!");
#endregion


//===== 1. Generel + Status =======
#region httpContext + status
//httpContext + Status , async + await
//to write code in block ---
//accept httpContext parameter
//app.Run(async (HttpContext context) =>
//{
//    //context.Response.StatusCode = 400;
//    context.Response.StatusCode = 200;
//    await context.Response.WriteAsync("Hello");
//});
#endregion

//===== 2. Response Header =======
#region ResponseHeader
////Date , Server , Content-Type , Content-Length
//app.Run(async (HttpContext context) => 
//{
//    //Header are iheaderDictunary  (keyvaluePair)
//    context.Response.Headers["MyKye_Pakistan"] = "Hum Zindaa Qoom";
//    context.Response.Headers["Content-Type"] = "text/html";
//    await context.Response.WriteAsync("<h1>Hello</h1>");
//    await context.Response.WriteAsync("<h2>Hello</h2>");
//});
#endregion

//===== 3. Request_Header ======= oposite
#region Request_Header opposite
app.Run(async (HttpContext context) =>
{
    var path = context.Request.Path;
    await context.Response.WriteAsync($"<h1>{path}</h1>");
});
#endregion

app.Run();
