using CustomerList.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerList.Repository
{
    public interface IOrderRepository
    {
        // Returns all orders. 
        Task<IEnumerable<Order>> GetAsync();

        // Returns the order with the given id.
        Task<Order> GetAsync(Guid orderId);

        // Returns all order with a data field matching the start of the given string. 
        Task<IEnumerable<Order>> GetAsync(string search);

        // Returns all the given customer's orders. 
        Task<IEnumerable<Order>> GetForCustomerAsync(Guid customerId);

        // Adds a new order if the order does not exist, updates the 
        Task<Order> UpsertAsync(Order order);

        // Deletes an order.
        Task DeleteAsync(Guid orderId);

    }
}
