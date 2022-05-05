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
            return new ProductDataService().GetAllProducts();
        }
    }
}