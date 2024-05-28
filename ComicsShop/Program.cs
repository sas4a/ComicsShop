using ComicsShop.Data.Interfaces;
using ComicsShop.Data.Mocks;
using Microsoft.Extensions.Hosting;
using System.Globalization;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Добавление сервисов в контейнер
        builder.Services.AddTransient<IAllComics, MockComics>();
        builder.Services.AddTransient<IComicsCategory, MockCategory>();

        // Добавление MVC и контроллеров с представлениями
        builder.Services.AddControllersWithViews();

        // Настройка культуры по умолчанию
        var cultureInfo = new CultureInfo("en-US");
        CultureInfo.DefaultThreadCurrentCulture = cultureInfo;

        var app = builder.Build();

        // Включение отладочных страниц и статических файлов
        if (app.Environment.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }
        else
        {
            app.UseExceptionHandler("/Home/Error");
            app.UseHsts();
        }

        app.UseStatusCodePages();
        app.UseStaticFiles();

        app.UseRouting();
        app.UseAuthorization();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            endpoints.MapControllerRoute(
                name: "comics",
                pattern: "{controller=Comics}/{action=List}/{enterCategory?}");
        });

        try
        {
            app.Run();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
            throw;
        }
    }
}