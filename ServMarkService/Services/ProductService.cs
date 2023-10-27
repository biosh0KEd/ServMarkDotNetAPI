using ServMarkService.Data;

namespace ServMarkService.Services;

public class ProductService
{
    private readonly ProductsContext _context;
    public ProductService(ProductsContext context)
    {
        _context = context;
    }
}