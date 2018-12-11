using CustomerList.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerList.WPF.ViewModels
{
    public class CustomerViewModel : BindableBase
    {
        // Creates a new customer model.
        public CustomerViewModel(Customer model) => Model = model ?? new Customer();

        private Customer _model;

        // The underlying customer model. Internal so it is not visible to the RadDataGrid. 
        internal Customer Model
        {
            get => _model;
            set
            {
                if (_model != value)
                {
                    _model = value;

                    // Raise the PropertyChanged event for all properties.
                    OnPropertyChanged(string.Empty);
                    OnPropertyChanged(nameof(FirstName));
                }
            }
        }

        // Gets or sets whether the underlying model has been modified. 
        // This is used when sync'ing with the server to reduce load
        // and only upload the models that changed.
        internal bool IsModified { get; set; }

        // Gets or sets the customer's first name.
        public string FirstName
        {
            get => Model.FirstName;
            set
            {
                if (value != Model.FirstName)
                {
                    Model.FirstName = value;
                    IsModified = true;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(Name));
                }
            }
        }

        // Gets or sets the customer's last name.
        public string LastName
        {
            get => Model.LastName;
            set
            {
                if (value != Model.LastName)
                {
                    Model.LastName = value;
                    IsModified = true;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(Name));
                }
            }
        }

        // Gets the customers full (first + last) name.
        public string Name => $"{FirstName} {LastName}";

        // Gets or sets the customer's address.
        public string Address
        {
            get => Model.Address;
            set
            {
                if (value != Model.Address)
                {
                    Model.Address = value;
                    IsModified = true;
                    OnPropertyChanged();
                }
            }
        }

        // Gets or sets the customer's company.
        public string Company
        {
            get => Model.Company;
            set
            {
                if (value != Model.Company)
                {
                    Model.Company = value;
                    IsModified = true;
                    OnPropertyChanged();
                }
            }
        }

        // Gets or sets the customer's phone number. 
        public string Phone
        {
            get => Model.Phone;
            set
            {
                if (value != Model.Phone)
                {
                    Model.Phone = value;
                    IsModified = true;
                    OnPropertyChanged();
                }
            }
        }

        // Gets or sets the customer's email. 
        public string Email
        {
            get => Model.Email;
            set
            {
                if (value != Model.Email)
                {
                    Model.Email = value;
                    IsModified = true;
                    OnPropertyChanged();
                }
            }
        }
    }
}
