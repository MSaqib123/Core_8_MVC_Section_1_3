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
//app.Run(async (HttpContext context) =>
//{
//    //Requst Path
//    var path = context.Request.Path;
//    //Requst Method (get,post)
//    var mathod = context.Request.Method;
//    await context.Response.WriteAsync($"<h1>{path}</h1>");
//    await context.Response.WriteAsync($"<h1>{mathod}</h1>");
//});
#endregion

//===== 3. Request_Header Query_String ======= 
#region Query_String
//app.Run(async (HttpContext context) =>
//{
//    if (context.Request.Method == "GET")
//    {
//        if (context.Request.Query.ContainsKey("id"))
//        {
//            string id = context.Request.Query["id"];
//            await context.Response.WriteAsync($"{id}");
//        }
//    }
//});
#endregion

//===== 4. Request_Header Importent Keys ======= 
#region 
app.Run(async (HttpContext context) =>
{
    if (context.Request.Headers.ContainsKey("User-Agent"))
    {
        string userAgent = context.Request.Headers["User-Agent"];
        await context.Response.WriteAsync($"<p>{userAgent}</p>");
    }
});
#endregion

app.Run();
