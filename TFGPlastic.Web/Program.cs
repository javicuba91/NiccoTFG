using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using TFGPlastic.Core.Controllers;
using TFGPlastic.Core.Entity;
using TFGPlastic.Infrastructure;
using TFGPlastic.Infrastructure.DataBase;
using TFGPlastic.UseCases;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<TFGPlasticDbContext>(options =>
               options.UseInMemoryDatabase("TFGPlasticDbContext"));

builder.Services.AddSession(op =>
{
    op.IdleTimeout = TimeSpan.FromHours(1);
    op.Cookie.HttpOnly = true;
    op.Cookie.IsEssential = true;
    });
builder.Services.AddScoped<ITareaRepository, TareaRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
//Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddHttpContextAccessor();
//Asume que tus manejadores están en el mismo ensamblado que Program. 
builder.Services.RegisterUseCases();
builder.Services.AddInfrastructureLayer();
builder.Services.AddScoped<ICustomAuthenticationService, CustomAuthenticationService>();
builder.Services.AddSession();
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
        .AddCookie(options =>
        {
            options.Cookie.HttpOnly = true;
            options.ExpireTimeSpan = TimeSpan.FromMinutes(30);
            options.LoginPath = "/Login"; // Ruta a la página de inicio de sesión
            options.AccessDeniedPath = "/LoginError"; // Ruta a la página de acceso denegado
        });

//builder.Services.AddRazorPages();
//builder.Services.AddHttpContextAccessor();
//builder.Services.RegisterUseCases();
//builder.Services.AddInfrastructureLayer();

var app = builder.Build();
//construir objetos con esas dependencias, en cualquier elemento cdu, el inyector de dependencias va a buscar el user
//repository, registrar el conjunto de casos de uso, necesitar el user repository, y su implementación, un poco de ddd.
//aplicación conoce a dominio

app.UseAuthentication();
//var appUser = builder.Build(); 


//Configure the HTTP request pipeline.

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();


app.UseSession();
app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");
});

app.UseAuthorization();

app.MapRazorPages();
app.Run();
