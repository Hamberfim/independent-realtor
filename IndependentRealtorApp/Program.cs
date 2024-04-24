using IndependentRealtorApp.Models; // separated domain models from data layer classes
using IndependentRealtorApp.Models.DomainModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Add EF Core services
builder.Services.AddDbContext<RealtorContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("RealtorContext")));

// Dependency Injection mapping
builder.Services.AddTransient<IUser, UserService>();
builder.Services.AddTransient<IProperty, PropertyService>();

// Identity services
builder.Services.AddIdentity<Realtor, IdentityRole>(options =>
{
    options.Password.RequiredLength = 6;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireDigit = false;
})
        .AddEntityFrameworkStores<RealtorContext>()
        .AddDefaultTokenProviders();

// TODO: enable session cookie and its expiration here
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromSeconds(5);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();


// TODO: use session services from above, must be called before any routes are mapped
app.UseSession();

app.MapAreaControllerRoute(
    name: "admin",
    areaName: "Admin",
    pattern: "Admin/{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "UserList",
    pattern: "{controller=User}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


await RealtorContext.CreateAdminUser(app.Services);

app.Run();
