using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.Identity.Web;
using Microsoft.Identity.Web.UI;
using System.Data.SqlClient;
using WhatYouNeed.Web.ActionFilters;
using WhatYouNeed.Web.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();


// Add services to the container.
builder.Services.AddAuthentication(OpenIdConnectDefaults.AuthenticationScheme)
    .AddMicrosoftIdentityWebApp(builder.Configuration.GetSection("AzureAd"));

builder.Services.AddAuthorization(options =>
{
    // By default, all incoming requests will be authorized according to the default policy.
    options.FallbackPolicy = options.DefaultPolicy;
});
builder.Services.AddRazorPages()
    .AddMicrosoftIdentityUI();

var authorizepolicy = new AuthorizationPolicyBuilder()
        .RequireAuthenticatedUser()
        .RequireRole("Admin", "SuperUser")
        .Build();

builder.Services.AddMvcCore(options =>
{
    //options.Filters.Add(new HandleErrorAttribute());
    options.Filters.Add(new ElmahErrorMVCAttribute());
    options.Filters.Add((Microsoft.AspNetCore.Mvc.Filters.IFilterMetadata)authorizepolicy);
});

builder.Services.AddMemoryCache();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

//app.UseMiddleware<ErrorHandlerMiddleware>();

app.UseHttpsRedirection();

// ?
app.UseWebOptimizer();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();
app.MapControllers();

app.MapControllerRoute(
    name: "Install",
    pattern: "{area:exists}/{controller=Install}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "Admin",
    pattern: "{area:exists}/{controller=Manage}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "Admin_default",
    pattern: "{area:exists}/{controller=Admin_default}/{action}/{id?}");

app.MapControllerRoute(
    name: "Pro_defaultExt",
    pattern: "{area:exists}/{controller=UserPro}/{action=Index}/{id?}");

 //app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
