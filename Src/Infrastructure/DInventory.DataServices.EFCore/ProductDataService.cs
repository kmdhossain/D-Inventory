using DInventory.DataServices.Interface;
using DInventory.Domains.Entities;
using Microsoft.EntityFrameworkCore;
using DInventory.DataServices.EFCore.AppDbContext;

namespace DInventory.DataServices.EFCore
{
    public class ProductDataService: IProductDataService
    {
        protected readonly AppDatabaseContext DbContext;

        public ProductDataService(AppDatabaseContext dbContext)
        {
            DbContext = dbContext;
        }

        public IList<Product> GetAllProducts()
        {
            return DbContext.Products.ToList();
        }

    }
}