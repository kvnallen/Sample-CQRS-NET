namespace CQRS.Common.Entities
{
    public class Product
    {
        public string Id { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }
        public bool IsOutOfStock { get; set; }
        public decimal Price { get; set; }
    }
}
