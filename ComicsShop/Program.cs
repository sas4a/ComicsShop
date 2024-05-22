using ComicsShop.Data.Interfaces;
using ComicsShop.Data.Mocks;
using Microsoft.AspNetCore.Mvc.RazorPages;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<IAllComics, MockComics>();
builder.Services.AddTransient<IComicsCategory, MockCategory>();
builder.Services.AddMvc();


var app = builder.Build();
//app.MapGet("/comics", () => new PageResult("/Pages/Comics.cshtml", repository.GetComics()));
app.UseDeveloperExceptionPage();
app.UseStatusCodePages();
app.UseStaticFiles();
app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Comics}/{action=List}");
});
//app.UseMvcWithDefaultRoute();
app.Run();