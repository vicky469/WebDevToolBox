using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TransformAPI.Model.Entity;

[Table("Products")]
public class ProductEntity

{
    [Key] public int ProductID { get; set; }

    public string ProductName { get; set; }

    [ForeignKey("Suppliers")] public int SupplierID { get; set; }

    [ForeignKey("Categories")] public int CategoryID { get; set; }
}