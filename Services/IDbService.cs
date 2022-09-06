using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProductDetails.Services
{
    public interface IDbService
    {
        Task<T> GetAsync<T>(string command, object parameter);
        Task<List<T>> GetAll<T>(string command, object parameter);
        Task<int> Edit(string command, object parameter);
    }
}
