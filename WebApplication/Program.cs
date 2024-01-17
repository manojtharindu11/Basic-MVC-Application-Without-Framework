using Microsoft.AspNetCore.Mvc.Formatters;
using System.Net.Mime;
using System.Text;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();



//app.MapGet("/", () => "Hello World!");

app.MapGet("/", (HttpContext context) =>
{
    /*   string html = @"<html>
                       <body>
                           <h1>Hello world</h1>
                           <br>
                           Welcome to this new world!
                       </body>
                       </html>";
    */
    string html = @"<html>
                        <head>
                            <title>miniHTML</title>
                        </head>
                        <body>
                            <h1>Simple Framework</h1> <br>

                            <form action=""/login"" method=""post"">

                                <label for = ""username"">User Name</label>
                                <input type=""text"" id=""username"" name = ""username"" required>

                                <label for = ""password"">Password</label>
                                <input type=""password"" id=""password"" name = ""password"" required>
    
                                <button type=""submit"">Submit</button>
                            </form>
                    </body>
                <html>";
    WriteHtml(context, html);
});

app.Map("/Login", (HttpContext context) =>
{
    var username = context.Request.Form["username"];
    var password = context.Request.Form["password"];

    if(username == "Manoj" && password == "1234")
    {
        var html = @"<html>
                        <head>
                            <title>miniHTML</title>
                        </head>
                        <body>
                            <h1>Simple Framework</h1>
                            <br>
                            <p>Welcome to the simple framework</p>
                        </body>
                    </html>";
        WriteHtml(context, html);
    } else
    {
        string html = @"<html>
                        <head>
                            <title>miniHTML</title>
                        </head>
                        <body>
                            <h1>Simple Framework</h1> <br>

                            <form action=""/login"" method=""post"">

                                <label for = ""username"">User Name</label>
                                <input type=""text"" id=""username"" name = ""username"" required>

                                <label for = ""password"">Password</label>
                                <input type=""password"" id=""password"" name = ""password"" required>
    
                                <button type=""submit"">Submit</button> <br>

                                <label style=""color:red"">Login failed</label>

                            </form>
                    </body>
                <html>";
        WriteHtml(context, html);
    }
});


app.Run();

void WriteHtml(HttpContext context, string html)
{
    context.Response.ContentType = MediaTypeNames.Text.Html;
    context.Response.ContentLength = Encoding.UTF8.GetByteCount(html);
    context.Response.WriteAsync(html);
}
