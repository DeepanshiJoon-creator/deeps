var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapDelete("/delete-example", (HttpContext context) =>
{
    return Results.Ok("This is a Delete request.");
});

//app.Map("/hello", () => "Hello World!");
//app.MapGet("/get-example", () => "This is a GET request.");
////app.MapPost("/post-example", (HttpContext context) =>
//{
//    return Results.Ok("This is a POST requets");
//});

//app.MapPut("/put-example", (HttpContext ContextBoundObject) =>
//{
//    return Results.Ok("This is a PUT request.");

//});
//app.Run(async context => await context.Response.WriteAsync("Hello"));


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
