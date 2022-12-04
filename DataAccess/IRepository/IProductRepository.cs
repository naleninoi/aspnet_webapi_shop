using Models;

namespace DataAccess.IRepository;

public interface IProductRepository
{
    Task<Product?> GetById(int id);

    Task<List<Product>> GetProducts();
}