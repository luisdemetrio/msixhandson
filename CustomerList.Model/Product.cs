using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerList.Model
{
    public class Product
    {
        public Guid Id { get; set; } = Guid.NewGuid(); // Gets or sets the database id.

        public string Name { get; set; } // Gets or sets the product's name.

        public string Color { get; set; } // Gets or sets the product's color.

        public int DaysToManufacture { get; set; }

        // Gets or sets the product's standard cost.
        public decimal StandardCost { get; set; }
        public decimal ListPrice { get; set; } // Gets or sets the product's list price.

        // Gets or sets the product's weight.
        public decimal Weight { get; set; }

        // Gets or sets the product's description.
        public string Description { get; set; }

        // Returns the name of the product and the list price.
        public override string ToString() => $"{Name} \n{ListPrice}";
    }
}
