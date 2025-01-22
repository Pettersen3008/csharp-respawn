namespace Respawn.Core.Domain.Models;

public class Product
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public string[] Images { get; set; }
    public string Condition { get; set; }
    public string Category { get; set; }
    public int SellerId { get; set; }
    public DateTime Created_At { get; set; }
}
