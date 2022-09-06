using ProductDetails.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProductDetails.Services
{
    public class ProductService : IProductService
    {
        private readonly IDbService _dbservice;
        public ProductService(IDbService dbService)
        {
            _dbservice = dbService;
        }
        public async Task<Product> CreateProduct(Product product)
        {
            var output = await _dbservice.Edit("INSERT into ProductDetails(Product_Name,Product_Code,Description,Price) VALUES(@Product_Name,@Product_Code,@Description,@Price)", product);

            return product;
        }

        public async Task<bool> DeleteProduct(int id)
        {
            var deleteProduct = await _dbservice.Edit("DELETE FROM ProductDetails WHERE id=@id", new { id });
            return true;
        }

        public async Task<List<Product>> GetProductList()
        {
            var productList = await _dbservice.GetAll<Product>("SELECT * from ProductDetails", new { });

            return productList;
        }

        public async Task<Product> GetProduct(int id)
        {
            var product = await _dbservice.GetAsync<Product>("SELECT * FROM ProductDetails where id=@Id", new { id });

            return product;
        }

        public async Task<Product> UpdateProduct(Product product)
        {
            var updateProduct = await _dbservice.Edit("UPDATE ProductDetails SET Product_Name=@Product_Name,Product_Code=@Product_Code,Description=@Description,Price=@Price WHERE Id=@Id", product);

            return product;
        }
    }
}
