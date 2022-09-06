using Dapper;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ProductDetails.Services
{
    public class DbService : IDbService
    {
        private readonly IDbConnection db;
        public DbService(IConfiguration configuration)
        {
            db = new SqlConnection(configuration.GetConnectionString("ProductConnectionString"));
        }
        public async Task<int> Edit(string command, object parameter)
        {
            int data;
            data = await db.ExecuteAsync(command, parameter);

            return data;
        }

        public async Task<List<T>> GetAll<T>(string command, object parameter)
        {
            List<T> products = new List<T>();
            products = (List<T>)await db.QueryAsync<T>(command, parameter);

            return products;
        }

        public async Task<T> GetAsync<T>(string command, object parameter)
        {
            T product;
            product = (await db.QueryAsync<T>(command, parameter).ConfigureAwait(false)).FirstOrDefault();

            return product;
        }
    }
}
