using DInventory.DataServices.EFCore;
using DInventory.Domains.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DInventory.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        [HttpGet()]
        public IEnumerable<Product> Get()
        {
            var db = new InMemoryDbContext();
            
            var testProducts = new List<Product>();

            for (int i = 0; i < 10; i++)
                testProducts.Add(
                    new Product {  ProductId = i + 1, ProductName = "Product:" + i}
                    );

            db.Products.AddRange(testProducts);
            db.SaveChanges();

            return new ProductDataService(db).GetAllProducts();
        }
    }
}