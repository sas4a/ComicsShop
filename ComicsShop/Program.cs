using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Globalization;
using ComicsShop.Data;
using ComicsShop.Data.Interfaces;
using ComicsShop.Data.Mocks;

using Microsoft.Extensions.Options;
using IHostingEnvironment = Microsoft.Extensions.Hosting.IHostingEnvironment;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        
        builder.Services.AddTransient<IAllComics, MockComics>();
        builder.Services.AddTransient<IComicsCategory, MockCategory>();
        builder.Services.AddMvc();
        builder.Services.AddControllersWithViews();
        
        


        var cultureInfo = new CultureInfo("en-US");
        CultureInfo.DefaultThreadCurrentCulture = cultureInfo;

        var app = builder.Build();
        app.UseDeveloperExceptionPage();
        app.UseStatusCodePages();
        app.UseStaticFiles();
        app.UseRouting();
        app.UseAuthorization();
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Comics}/{action=List}");
        });
        
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
            app.UseHsts();
        }
        
        app.Run();
    }
}