using System.ComponentModel.DataAnnotations.Schema;

namespace LINQpractice;

[Table("Product",Schema ="Production")]
public class Product
{
    public int ProductId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Color { get; set; }
    public decimal ListPrice { get; set; }
    public string? Size { get; set; }
    public int? ProductSubcategoryID { get; set; }
    public ProductSubcategory? ProductSubcategory { get; set; }

    public override string ToString()
    {
        return $"ID: {ProductId}, Név: {Name}, Szín: {Color}, ListaÁr: {ListPrice:N2}, Méret: {Size}, Alkategória: {ProductSubcategory}";
    }

}
