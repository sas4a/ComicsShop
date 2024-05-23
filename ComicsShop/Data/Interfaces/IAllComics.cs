using ComicsShop.Data.Models;

namespace ComicsShop.Data.Interfaces;

public interface IAllComics
{
    IEnumerable<Comic> Comics { get;  }
    IEnumerable<Comic> getFavComic { get; }
    Comic getObjectComic(int comicId);
}