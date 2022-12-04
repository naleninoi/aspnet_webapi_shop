using DataAccess.IRepository;
using Microsoft.EntityFrameworkCore;
using Models;

namespace DataAccess.Repository;

public class ProductRepository : IProductRepository
{
    private AppDbContext _context;

    public ProductRepository(AppDbContext context)
    {
        _context = context;
    }

    public Task<Product?> GetById(int id)
    {
        return _context.Products
            .Where(p => p.Id == id)
            .Where(p => p.isActive)
            .FirstOrDefaultAsync();
    }

    public Task<List<Product>> GetProducts()
    {
        return _context.Products
            .Where(p => p.isActive)
            .ToListAsync();
    }
}