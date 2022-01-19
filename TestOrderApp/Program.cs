

using BuissnesLayer;
using BuissnesLayer.Implemenation;
using BuissnesLayer.Interfaces;
using DataLayer;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connection = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<EFDBContext>(options => options.UseSqlServer(connection));

builder.Services.AddTransient<IOrderRepository, EFOrderRepository>();

builder.Services.AddScoped<DataManager>();

builder.Services.AddControllersWithViews();


builder.Services.AddMvc();


var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();



app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");



app.Run();
