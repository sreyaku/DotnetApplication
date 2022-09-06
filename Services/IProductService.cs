using ProductDetails.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProductDetails.Services
{
    public interface IProductService
    {
        Task<Product> CreateProduct(Product product);
        Task<List<Product>> GetProductList();
        Task<Product> GetProduct(int id);
        Task<Product> UpdateProduct(Product product);
        Task<bool> DeleteProduct(int id);
    }
}
