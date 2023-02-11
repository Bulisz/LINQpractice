using System.ComponentModel.DataAnnotations.Schema;

namespace LINQpractice;

[Table("ProductCategory", Schema = "Production")]
public class ProductCategory
{
    public int ProductCategoryID { get; set; }
    public string Name { get; set; } = string.Empty;
    public ICollection<ProductSubcategory> ProductSubcategories { get; set; } = new List<ProductSubcategory>();

    public override string ToString()
    {
        return $"{Name}";
    }
}