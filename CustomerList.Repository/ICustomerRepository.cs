using CustomerList.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerList.Repository
{
    public interface ICustomerRepository
    {
        // Returns all customers. 
        Task<IEnumerable<Customer>> GetAsync();

        // Returns all customers with a data field matching the start of the given string. 
        Task<IEnumerable<Customer>> GetAsync(string search);

        // Returns the customer with the given id. 
        Task<Customer> GetAsync(Guid id);

        // Adds a new customer if the customer does not exist, updates the 
        // existing customer otherwise.
        Task<Customer> UpsertAsync(Customer customer);

        // Deletes a customer.
        Task DeleteAsync(Guid customerId);
    }
}
