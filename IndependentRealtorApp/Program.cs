using IndependentRealtorApp.Models.DataLayer;
using Microsoft.EntityFrameworkCore;
using IndependentRealtorApp.Area.Admin.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using IndependentRealtorApp.Models.DomainModels;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Add EF Core services
builder.Services.AddDbContext<RealtorContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("RealtorContext")));

builder.Services.AddScoped<PropertyService>();

// Identity services
builder.Services.AddIdentity<Realtor, IdentityRole>(options => {
    // override default password setting
    options.Password.RequiredLength = 6;
    options.Password.RequireUppercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireDigit = false;
}).AddEntityFrameworkStores<RealtorContext>().AddDefaultTokenProviders();

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

app.MapAreaControllerRoute(
    name: "admin",
    areaName: "Admin",
    pattern: "Admin/{controller=Property}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "UserList",
    pattern: "{controller=PublicUsers}/{action=Index}/{id?}");


// await RealtorContext.CreateAdminUser(app.Services);

app.Run();
