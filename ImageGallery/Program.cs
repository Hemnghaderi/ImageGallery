using Microsoft.EntityFrameworkCore;
using ImageGallery.Contexts;
using ImageGallery.Models.Identity;
using ImageGallery.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DataContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("Sql")));
builder.Services.AddScoped<AccountService>();
builder.Services.ConfigureApplicationCookie(x => x.LoginPath = "/account/login");
builder.Services.AddDefaultIdentity<GalleryUser>(x =>
{
    x.SignIn.RequireConfirmedAccount = true; 
}).AddEntityFrameworkStores<DataContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();



app.UseHsts();


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
