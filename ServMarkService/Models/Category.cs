using System.Text.Json.Serialization;

namespace ServMarkService.Models;

public class Category
{
    public int? Id { get; set; }
    public string Name { get; set; }
    public string TypeImg { get; set; }
    [JsonIgnore]
    public virtual ICollection<Product.Product> Products {get;set;}
}