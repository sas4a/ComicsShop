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
                    categoryName = "DC", desc = "DC Entertainment является дочерней компанией " +
                                                "Warner Bros. Entertainment."
                },
                new Category
                {
                    
                    categoryName = "Marvel", desc = "Aмериканский издатель комиксов, " +
                                                    "дочерняя компания  The Walt Disney Company."
                }
            };
        }
    }
}