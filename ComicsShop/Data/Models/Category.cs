namespace ComicsShop.Data.Models;

public class Category
{
    public int id { set; get; }
    public string categoryName { set; get; }
    public string desc { set; get; }
    public List<Comic> comics { set; get; }
}