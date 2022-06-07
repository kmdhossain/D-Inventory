using DInventory.DataServices.EFCore;
using DInventory.DataServices.EFCore.AppDbContext;
using DInventory.Domains.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Data.Entity;

namespace DInventory.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        [HttpGet()]
        public IEnumerable<Product> Get()
        {
            AppDatabaseContext db = new InMemoryDbContext();
            
            var testProducts = new List<Product>();

            for (int i = 0; i < 10; i++)
                testProducts.Add(
                    new Product {  ProductId = i + 1, ProductName = "Product:" + i}
                    );

            db.Products.AddRange(testProducts);
            db.SaveChanges();

            return new ProductDataService(db).GetAllProducts();

        }
        //public virtual async Task<TList> Add(List list)
        //{
        //    var obj = DbContext.Add(list);

        //    await DbContext.SaveChangesAsync();

        //    return obj.Entity;
        //}


    }
}