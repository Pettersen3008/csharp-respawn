using Respawn.Core.Domain.Models;

namespace Respawn.Core.Application.Contracts;

public interface IProductRepository
{
    Task<IEnumerable<Product>> GetProductsAsync();
    Task<Product?> GetProductAsync(string productId);
    Task SaveProductAsync(Product product);
    Task UpdateProductAsync(Product product);
    Task DeleteProductAsync(Product product);
}