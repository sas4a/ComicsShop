using ComicsShop.Data.Interfaces;
using ComicsShop.Data.Models;

namespace ComicsShop.Data.Mocks;

public class MockComics : IAllComics
{
    private readonly IComicsCategory _comicsCategory = new MockCategory();

    public IEnumerable<Comic> Comics =>
        new List<Comic>
        {
            new Comic
            {
                name = "Heroes of Earth: Rebirth of a Legend",
                shortDesc = "SuperMan",
                longDesc = "The return of heroes to protect the world",
                img = "/Users/mac/RiderProjects/ComicsShop/2024-05-21_13-40-17.png",
                price = 6,
                isFavourite = true,
                available = true,
                Category = _comicsCategory.AllCategories.First()
            },

            new Comic
            {
                name = "Chronicles of the Dark World: Rise of Darkness",
                shortDesc = "SuperMan",
                longDesc = "The fight between light and darkness",
                img = "/Users/mac/RiderProjects/ComicsShop/2024-05-21_13-41-59.png",
                price = 6,
                isFavourite = true,
                available = true,
                Category = _comicsCategory.AllCategories.First()
            }
        };

    public IEnumerable<Comic> getFavComic { get; set; }

    public Comic getObjectComic(int comicId)
    {
        throw new NotImplementedException();
    }
}