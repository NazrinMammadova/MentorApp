using MentorApp.DAL;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var config = builder.Configuration;
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(config.GetConnectionString("DefaultConnection"));
});

var app = builder.Build();

app.MapControllerRoute("default",
    "{controller=home}/{action=index}/{id?}");
app.UseStaticFiles();

app.Run();

