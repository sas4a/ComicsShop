using ComicsShop.Data.Interfaces;
using ComicsShop.Data.Models;

namespace ComicsShop.Data.Mocks;

public class MockCategory : IComicsCategory
{
    public IEnumerable<Category> AllCategories
    {
        get
        {
            return new List<Category>
            {
                new Category
                {
                    categoryName = "DC", desc = "DC Entertainment is a subsidiary of " +
                                                "Warner Bros. Entertainment."
                },
                new Category
                {
                    
                    categoryName = "Marvel", desc = "American comics publisher, " +
                                                    "subsidiary of The Walt Disney Company."
                }
            };
        }
    }
}