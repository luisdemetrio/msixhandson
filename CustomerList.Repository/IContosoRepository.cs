using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerList.Repository
{
    public interface IContosoRepository
    {
        // Returns the customers repository.
        ICustomerRepository Customers { get; }

        // Returns the orders repository.
        IOrderRepository Orders { get; }

        // Returns the products repository.
        IProductRepository Products { get; }
    }
}
