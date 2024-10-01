namespace ProductService.API.Models.Request;

public class ProductRequest
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }
}