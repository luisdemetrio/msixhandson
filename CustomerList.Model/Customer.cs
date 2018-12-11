using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerList.Model
{
    public class Customer : IEquatable<Customer>
    {

        public Guid Id { get; set; } = Guid.NewGuid(); // Gets or sets the database id.

        public string FirstName { get; set; } // Gets or sets the customer's first name.

        public string LastName { get; set; } // Gets or sets the customer's last name.

        public string Company { get; set; } // Gets or sets the customer's company.

        public string Email { get; set; } // Gets or sets the customer's email.

        public string Phone { get; set; } // Gets or sets the customer's phone number.

        public string Address { get; set; } // Gets or sets the customer's address.

        /// A list of the customer's orders. 
        public virtual List<Order> Orders { get; set; }


        // Returns the customer's name.
        public override string ToString() => $"{FirstName} {LastName}";

        public bool Equals(Customer other) =>
                FirstName == other.FirstName &&
                LastName == other.LastName &&
                Company == other.Company &&
                Email == other.Email &&
                Phone == other.Phone &&
                Address == other.Address;

        public Customer Clone() => (Customer)MemberwiseClone();
    }
}
