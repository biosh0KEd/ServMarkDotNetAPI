using Microsoft.EntityFrameworkCore;
using ServMarkService.Data;

namespace ServMarkService.Services.Product;

public class ProductService : IProductService
{
    private readonly ProductsContext _context;
    public ProductService(ProductsContext context)
    {
        _context = context;
    }
    public IEnumerable<Models.Product.Product> GetAll(int? limit, int? offset)
    {
        if (limit is not null)
        {
            return offset is null ? 
                _context.Products
                    .Include(p => p.Category)
                    .Include(p => p.Images)
                    .Take((int)limit).ToList() : 
                _context.Products
                    .Include(p => p.Category)
                    .Include(p => p.Images)
                    .Skip((int)offset).Take((int)limit).ToList();
        }
        else
        {
            return offset is null ? 
                _context.Products
                    .Include(p => p.Category)
                    .Include(p => p.Images)
                    .ToList() : 
                _context.Products
                    .Include(p => p.Category)
                    .Include(p => p.Images)
                    .Skip((int)offset).ToList();
        }
    }
    public Models.Product.Product GetById(int id)
    {
        return _context.Products
            .Include(p => p.Category)
            .Include(p => p.Images)
            .FirstOrDefault(p => p.Id == id)!;
    }
    public async Task Add(Models.Product.Product product)
    {
        _context.Products.Add(product);
        await _context.SaveChangesAsync();
    }
    public async Task Update(int id, Models.Product.Product product)
    {
        var productActual = await _context.Products.FindAsync(id);
        if (productActual != null)
        {
            productActual.Title = product.Title;
            productActual.Description = product.Description;
            productActual.Price = product.Price;
            productActual.CategoryId = product.CategoryId;
            await _context.SaveChangesAsync();
        }
    }
    public async Task Delete(int id)
    {
        var productActual = await _context.Products.FindAsync(id);
        if (productActual != null)
        {
            _context.Products.Remove(productActual);
            await _context.SaveChangesAsync();
        }
    }
}

public interface IProductService
{
    IEnumerable<Models.Product.Product> GetAll(int? limit, int? offset);
    Models.Product.Product GetById(int id);
    Task Add(Models.Product.Product product);
    Task Update(int id, Models.Product.Product product);
    Task Delete(int id);
}