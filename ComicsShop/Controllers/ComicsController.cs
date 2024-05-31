using ComicsShop.Data.Interfaces;
using ComicsShop.Data.Models;
using ComicsShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ComicsShop.Controllers
{
    public class ComicsController : Controller
    {
        private readonly IAllComics _allComics;
        private readonly IComicsCategory _allCategory;

        public ComicsController(IAllComics iAllComics, IComicsCategory iComicsCategory)
        {
            _allComics = iAllComics;
            _allCategory = iComicsCategory;
        }

        [Route("Comics/List")]
        [Route("Comics/List/{enterCategory?}")]
        public ViewResult List(string enterCategory)
        {
            string category = enterCategory;
            string currentCategory = "";
            IEnumerable<Comic> comics = null;

            if (string.IsNullOrEmpty(category) || string.Equals("all", category, StringComparison.OrdinalIgnoreCase))
            {
                comics = _allComics.Comics.OrderBy(x => x.id);
            }
            else
            {
                if (string.Equals("Marvel", category, StringComparison.OrdinalIgnoreCase))
                {
                    comics = _allComics.Comics.Where(x => x.Category.categoryName.Equals("Marvel")).OrderBy(x => x.id);
                }
                else if (string.Equals("DC", category, StringComparison.OrdinalIgnoreCase))
                {
                    comics = _allComics.Comics.Where(x => x.Category.categoryName.Equals("DC")).OrderBy(x => x.id);
                }

                currentCategory = category;
            }

            var comicObj = new ComicsListViewModel
            {
                AllComics = comics,
                currentCategory = currentCategory
            };

            ViewBag.Title = "Page with comics";

            return View(comicObj);
        }
    }
}