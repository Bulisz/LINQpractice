using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace LINQpractice;

[Table("ProductSubcategory",Schema ="Production")]
public class ProductSubcategory
{
    public int ProductSubcategoryID { get; set; }
    public string Name { get; set; } = string.Empty;
    public int ProductCategoryID { get; set; }
    public ProductCategory ProductCategory { get; set; }
    public ICollection<Product> Products { get; set; } = new List<Product>();

    public override string ToString()
    {
        return $"{Name}, Kategória: {ProductCategory}";
    }
}