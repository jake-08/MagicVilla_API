using MagicVilla_Web;
using MagicVilla_Web.Services;
using MagicVilla_Web.Services.IServices;
using Microsoft.AspNetCore.Authentication.Cookies;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Add AutoMapper Configuration to the Services
builder.Services.AddAutoMapper(typeof(MappingConfig));

// Add VillaService HttpClient
builder.Services.AddHttpClient<IVillaService, VillaService>();

// Register VillaService to Dependency Injection using AddScoped
builder.Services.AddScoped<IVillaService, VillaService>();

// Add VillaNumberService HttpClient
builder.Services.AddHttpClient<IVillaNumberService, VillaNumberService>();

// Register VillaService to Dependency Injection using AddScoped
builder.Services.AddScoped<IVillaNumberService, VillaNumberService>();

// Add VillaNumberService HttpClient
builder.Services.AddHttpClient<IAuthService, AuthService>();

// Register VillaService to Dependency Injection using AddScoped
builder.Services.AddScoped<IAuthService, AuthService>();

// Register HttpContextAccessor to access session
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

// Enable the app to store bearer token in session 
builder.Services.AddDistributedMemoryCache();
builder.Services.AddAuthentication(options =>
    {
        options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
        options.DefaultChallengeScheme = "oidc";
    })
    .AddCookie(options =>
    {
        options.Cookie.HttpOnly = true;
        options.ExpireTimeSpan = TimeSpan.FromMinutes(30);
        options.LoginPath = "/Auth/Login";
        options.AccessDeniedPath = "/Auth/AccessDenied";
        options.SlidingExpiration = true;
    });
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(10);
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

app.UseSession();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
