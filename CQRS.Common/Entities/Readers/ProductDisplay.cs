namespace CQRS.Common.Entities.Readers
{
    public class ProductDisplay
    {
        public string Description { get; set; }
        public bool IsOutOfStock { get; set; }
        public decimal Price { get; set; }
    }
}