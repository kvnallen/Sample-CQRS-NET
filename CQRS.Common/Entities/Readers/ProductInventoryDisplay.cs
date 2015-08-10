namespace CQRS.Common.Entities.Readers
{
    public class ProductInventoryDisplay
    {
        public string Id { get; set; }
        public string Description { get; set; }
        public int CurrentStock { get; set; }
    }
}