namespace ServMarkService.Models;

public class Product
{
    public int? Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public int CategoryId { get; set; }
    public virtual Category Category { get; set; }
    public List<string> Images { get; set; }
}