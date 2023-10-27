namespace ServMarkService.Models;

public class Product
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public int CategoryID { get; set; }
    public Category Category { get; set; }
    public List<string> Images { get; set; }
}