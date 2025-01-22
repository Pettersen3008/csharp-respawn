using Respawn.Core.Application.Contracts;
using Respawn.Core.Application.Interfaces;
using Respawn.Core.Domain.Models;

namespace Respawn.Core.Application.Services;

public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;
    
    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }
    
    public async Task<IEnumerable<Product>> GetProductsAsync()
    {
        return await _productRepository.GetProductsAsync();
    }
    
    public async Task<Product?> GetProductAsync(string productId)
    {
        return await _productRepository.GetProductAsync(productId);
    }
    
    public async Task SaveProductAsync(Product product)
    {
        await _productRepository.SaveProductAsync(product);
    }
    
    public async Task UpdateProductAsync(Product product)
    {
        await _productRepository.UpdateProductAsync(product);
    }
    
    public async Task DeleteProductAsync(Product product)
    {
        await _productRepository.DeleteProductAsync(product);
    }
}