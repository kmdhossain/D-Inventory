using DInventory.Domains.Entities;

namespace DInventory.DataServices.Interface;

public interface IProductDataService
{
    IList<Product> GetAllProducts();
   

}
