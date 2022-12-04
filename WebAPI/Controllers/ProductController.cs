using DataAccess.IRepository;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    private readonly ILogger<ProductController> _logger;
    private readonly IProductRepository _productRepository;

    public ProductController(
        ILogger<ProductController> logger,
        IProductRepository productRepository)
    {
        _logger = logger;
        _productRepository = productRepository;
    }
    
    [HttpGet(Name = "Products")]
    public Task<List<Product>> GetAll()
    {
        return _productRepository.GetProducts();
    }
}