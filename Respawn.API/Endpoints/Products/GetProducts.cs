using Microsoft.AspNetCore.Mvc;
using Respawn.Core.Application.Interfaces;

namespace Respawn.API.Endpoints.Products;

public static class GetProducts
{
    public static void MapGetProducts(this WebApplication app)
    {
        app.MapGet("/products", async ([FromServices] IProductService productService) =>
        {
            var products = await productService.GetProductsAsync();
            return Results.Json(products);
        });
    }
}