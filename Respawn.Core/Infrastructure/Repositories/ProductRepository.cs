using Microsoft.EntityFrameworkCore;
using Respawn.Core.Application.Contracts;
using Respawn.Core.Domain.Models;
using Respawn.Core.Infrastructure.Extensions;

namespace Respawn.Core.Infrastructure.Repositories;

public class ProductRepository : IProductRepository
{
    private readonly AppDbContext _context;

    public ProductRepository(AppDbContext context)
    {
        _context = context;
    }
    
    public async Task<IEnumerable<Product>> GetProductsAsync()
    {
        return await _context.Products.ToListAsync();
    }
    
    public async Task<Product?> GetProductAsync(string productId)
    {
        return await _context.Products.FindAsync(productId);
    }
    
    
    public async Task SaveProductAsync(Product product)
    {
        _context.Products.Add(product);
        await _context.SaveChangesAsync();
    }
    
    public async Task UpdateProductAsync(Product product)
    {
        _context.Products.Update(product);
        await _context.SaveChangesAsync();
    }
    
    public async Task DeleteProductAsync(Product product)
    {
        _context.Products.Remove(product);
        await _context.SaveChangesAsync();
    }
}