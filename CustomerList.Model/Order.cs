using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerList.Model
{
    public class Order // Represents a customer order. 
    {
        public Order()
        { }

        // Gets or sets the database id.
        public Guid Id { get; set; } = Guid.NewGuid();

        // Creates a new order for the given customer.
        public Order(Customer customer) : this()
        {
            Customer = customer;
            CustomerName = $"{customer.FirstName} {customer.LastName}";
            Address = customer.Address;
        }

        public Guid CustomerId { get; set; } // Gets or sets the id of the customer placing the order.

        public Customer Customer { get; set; } // Gets or sets the customer placing the order.

        // Gets or sets the name of the customer placing the order.
        public string CustomerName { get; set; }

        public int InvoiceNumber { get; set; } = 0; // Gets or sets the invoice number.

        public string Address { get; set; } // Gets or sets the order shipping address.

        // Gets or sets the items in the order.
        public virtual List<LineItem> LineItems { get; set; } = new List<LineItem>();

        // Gets or sets when the order was placed.
        public DateTime DatePlaced { get; set; } = DateTime.Now;

        // Gets or sets when the order was filled.
        public DateTime? DateFilled { get; set; } = null;

        // Gets or sets the order's status.
        public OrderStatus Status { get; set; } = OrderStatus.Open;

        // Gets or sets the order's payment status.
        public PaymentStatus PaymentStatus { get; set; } = PaymentStatus.Unpaid;

        public Term Term { get; set; } // Gets or sets the order's term.

        /// Gets the order's subtotal.
        public decimal Subtotal => LineItems.Sum(lineItem => lineItem.Product.ListPrice * lineItem.Quantity);

        public decimal Tax => Subtotal * .095m; // Gets the order's tax.

        public decimal GrandTotal => Subtotal + Tax;  // Gets the order's grand total.

        /// Returns the invoice number.
        public override string ToString() => InvoiceNumber.ToString();
    }

    // Represents the term for an order.
    public enum Term
    {
        Net1,
        Net5,
        Net15,
        Net30
    }

    // Represents the payment status for an order.
    public enum PaymentStatus
    {
        Unpaid,
        Paid
    }

    // Represents the status of an order.
    public enum OrderStatus
    {
        Open,
        Filled,
        Cancelled
    }
}
