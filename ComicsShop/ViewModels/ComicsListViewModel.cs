using ComicsShop.Data.Models;

namespace ComicsShop.ViewModels;

public class ComicsListViewModel
{
    public IEnumerable<Comic> AllComics { get; set; }
    public string currentCategory { get; set; }
}