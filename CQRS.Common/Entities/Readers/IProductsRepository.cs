using System.Collections.Generic;

namespace CQRS.Common.Entities.Readers
{
    public interface IProductsRepository
    {
        ProductDisplay GetById(string id);
        IEnumerable<ProductDisplay> GetByDesc(string description);
        IEnumerable<ProductInventoryDisplay> FindOutOfStockProducts();
    }
}