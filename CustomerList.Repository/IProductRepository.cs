using CustomerList.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerList.Repository
{
    public interface IProductRepository
    {
        // Returns all products. 
        Task<IEnumerable<Product>> GetAsync();

        // Returns the product with the given Id. 
        Task<Product> GetAsync(Guid id);

        // Returns all products with a data field matching the start of the given string. 
        Task<IEnumerable<Product>> GetAsync(string search);
    }
}
