using Microsoft.EntityFrameworkCore;
using IndependentRealtorApp.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Add EF Core services to the container
builder.Services.AddDbContext<RealtorContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("RealtorContext")));

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

app.UseAuthorization();

// TODO: use session services from above, must be called before any routes are mapped
app.UseSession();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
