namespace Onion.Domain.Entities
{
    public class Product
    {
        public Product()
        {
            ProductId = Guid.NewGuid();
        }
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; } // Navigation property
    }
}
