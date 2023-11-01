using ServMarkService.Data;
using ServMarkService.Models;

namespace ServMarkService.Services;

public class CategoryService : ICategoryService
{
    private readonly ProductsContext _context;
    public CategoryService(ProductsContext context)
    {
        _context = context;
    }
    public IEnumerable<Category> Get()
    {
        return _context.Categories.ToList();
    }
    public IEnumerable<Models.Product.Product> GetProducts(int categoryId)
    {
        return _context.Products.Where(x => x.CategoryId == categoryId).ToList();
    }
    public async Task Add(Category category)
    {
        _context.Categories.Add(category);
        await _context.SaveChangesAsync();
    }
    public async Task Update(int id, Category category)
    {
        var currentCategory = await _context.Categories.FindAsync(id);
        if (currentCategory != null)
        {
            currentCategory.Name = category.Name;
            currentCategory.TypeImg = category.TypeImg;
            await _context.SaveChangesAsync();
        }
    }
    public async Task Delete(int id)
    {
        var currentCategory = await _context.Categories.FindAsync(id);
        if (currentCategory != null)
        {
            _context.Categories.Remove(currentCategory);
            await _context.SaveChangesAsync();
        }
    }
}

public interface ICategoryService
{
    IEnumerable<Category> Get();
    IEnumerable<Models.Product.Product> GetProducts(int categoryId);
    Task Add(Category category);
    Task Update(int id, Category category);
    Task Delete(int id);
}