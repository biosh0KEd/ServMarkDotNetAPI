using ServMarkService.Data;
using ServMarkService.Models.Product;

namespace ServMarkService.Services.Product;

public class ImageService : IImageService
{
    private readonly ProductsContext _context;
    public ImageService(ProductsContext context)
    {
        _context = context;
    }
    public IEnumerable<Image> Get()
    {
        return _context.Images.ToList();
    }
    public async Task Add(Image image)
    {
        _context.Images.Add(image);
        await _context.SaveChangesAsync();
    }
    public async Task Update(int id, Image image)
    {
        var currentImage = await _context.Images.FindAsync(id);
        if (currentImage != null)
        {
            currentImage.Url = image.Url;
            currentImage.Alt = image.Alt;
            currentImage.ProductId = image.ProductId;
            await _context.SaveChangesAsync();
        }
    }
    public async Task Delete(int id)
    {
        var currentImage = await _context.Images.FindAsync(id);
        if (currentImage != null)
        {
            _context.Images.Remove(currentImage);
            await _context.SaveChangesAsync();
        }
    }
}

public interface IImageService
{
    IEnumerable<Image> Get();
    Task Add(Image image);
    Task Update(int id, Image image);
    Task Delete(int id);
}