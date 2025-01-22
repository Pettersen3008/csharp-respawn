

using Respawn.Core.Domain.Models;

namespace Respawn.API.Endpoints.Products;

public static class GetProducts
{
    public static void MapGetProducts(this WebApplication app)
    {
        app.MapGet("/products", async () =>
        {
            // var products = await productRepository.GetProductsAsync();
            var res = new List<Product>
            {
                new Product { Id = 1, Title = "Product 1" },
                new Product { Id = 2, Title = "Product 2" },
                new Product { Id = 3, Title = "Product 3" }
            };
            return Results.Json(res);
        });
    }
}