using DataAccessLayer.Models;
using DataAccessLayer.Repositories;
using Microsoft.DotNet.Scaffolding.Shared.ProjectModel;
using Microsoft.EntityFrameworkCore;
using TraineeSocialAppMVC.UOW;

namespace TraineeSocialAppMVC
{
   
    public class Program
    {
        public static void Main(string[] args)
        {
            
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            //Add Database context
            var ConnectionString = builder.Configuration.GetConnectionString("SocialAppDB");
            builder.Services.AddDbContext<SocialAppDBContext>(
                options => options.UseSqlServer(ConnectionString));

            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
           // builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
            
           // builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
            var app = builder.Build();
            //repository
            //builder.Services.AddScoped<IUnitOfWork>();

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

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}