using ServMarkService.Data;

namespace ServMarkService.Services;

public class CategoryService
{
    private readonly ProductsContext _context;
    public CategoryService(ProductsContext context)
    {
        _context = context;
    }
}