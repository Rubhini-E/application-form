var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");
app.MapControllerRoute("default", "{Controller=Home}/{action=Index}/{id?}");

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.Run();

