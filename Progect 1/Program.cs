using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;
using Progect_1.Models;
using Progect_1.Models.Interface;
using Progect_1.Models.Realization;
using Progect_1.Storage;
using System.Configuration;
//using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
var connectionString = builder.Configuration.GetConnectionString("DbConnection");
builder.Services.AddTransient<IPersonModel, PersonModel>();
builder.Services.AddTransient<ICafe_StaffModel, Cafe_StaffModel>();
builder.Services.AddTransient<ICreatorModel, CreatorModel>();
builder.Services.AddTransient<IGeoDatasModel, GeoDatasModel>();
builder.Services.AddTransient<IIngredientModel, IngredientModel>();
builder.Services.AddTransient<IOrderModel, OrderModel>();
builder.Services.AddTransient<IReviewModel, ReviewModel>();
builder.Services.AddTransient<IMenuModel, MenuModel>();
builder.Services.AddDbContext<ExampleContex>();



var app = builder.Build();
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

