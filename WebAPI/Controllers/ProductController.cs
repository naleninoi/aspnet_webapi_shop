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
    
    [HttpGet("GetAll")]
    public async Task<List<Product>> GetAll()
    {
        return await _productRepository.GetProducts();
    }
    
    [HttpGet("GetById")]
    public async Task<Product?> GetById(int id)
    {
        return await _productRepository.GetById(id);
    }
}