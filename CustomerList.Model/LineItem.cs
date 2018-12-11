using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerList.Model
{
    public class LineItem
    {
        /// Gets or sets the id of the order the line item is associated with.
        public Guid OrderId { get; set; }

        public Guid Id { get; set; } = Guid.NewGuid(); // Gets or sets the database id.

        /// Gets or sets the order the line item is associated with.
        public Order Order { get; set; }

        public Guid ProductId { get; set; } // Gets or sets the product's id.

        public Product Product { get; set; } // Gets or sets the product.

        public int Quantity { get; set; } = 1; // Gets or sets the quantity of product. 
    }
}
