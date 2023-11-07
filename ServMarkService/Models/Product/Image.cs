using System.Text.Json.Serialization;

namespace ServMarkService.Models.Product;

public class Image
{
    public int? Id { get; set; }
    public string Url { get; set; }
    public string Alt { get; set; }
    public int ProductId { get; set; }
    [JsonIgnore]
    public virtual Product Product { get; set; }
}