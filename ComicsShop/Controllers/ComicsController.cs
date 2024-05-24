using ComicsShop.Data.Interfaces;
using ComicsShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
namespace ComicsShop.Controllers;


public class ComicsController : Controller
{
    private readonly IAllComics _allComics;
    private readonly IComicsCategory _allCategory;

    public ComicsController(IAllComics iAllComics, IComicsCategory iComicsCategory)
    {
        _allComics = iAllComics;
        _allCategory = iComicsCategory;
    }
    public ViewResult List()
    {
        ViewBag.Title = "Page with comics";
        ComicsListViewModel obj = new ComicsListViewModel();
        obj.AllComics = _allComics.Comics;
        obj.currentCategory = "All Comics";
        return View(obj);
    }
}