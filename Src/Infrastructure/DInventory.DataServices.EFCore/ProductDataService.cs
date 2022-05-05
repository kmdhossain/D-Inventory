using DInventory.DataServices.Interface;
using DInventory.Domains.Entities;

namespace DInventory.DataServices.EFCore
{
    public class ProductDataService : IProductDataService
    {
        public IList<Product> GetAllProducts() => new List<Product>
                {
                    new Product
                    {
                        ProductName = "Cokacola",
                        ProductId = 1,
                        UnitPrice = 1.00f,
                        UnitCost = 0.9f
                    }
            };
    }
}