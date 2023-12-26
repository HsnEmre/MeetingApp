using Microsoft.Extensions.FileSystemGlobbing.Internal.Patterns;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();//MVC Yapýsýný dahil ettik

var app = builder.Build();

app.MapControllerRoute(name:"default",
                              pattern: "{controller=Home}/{action=action}/{id?}");

app.Run();
