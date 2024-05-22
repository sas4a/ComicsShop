using ComicsShop.Data.Models;

namespace ComicsShop.Data.Interfaces;

public interface IComicsCategory
{
    IEnumerable<Category> AllCategories { get; }
}