using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerList.WPF.ViewModels
{
    public class CustomerListPageViewModel : BindableBase
    {

        /// Creates a new CustomerListPageViewModel.
        public CustomerListPageViewModel() => Task.Run(GetCustomerListAsync);

        /// The collection of customers in the list. 
        public ObservableCollection<CustomerViewModel> Customers { get; }
            = new ObservableCollection<CustomerViewModel>();

        /// Gets the complete list of customers from the database.
        public async Task GetCustomerListAsync()
        {
          

            var customers = await App.Repository.Customers.GetAsync();

            if (customers == null)
            {
                return;
            }

           
                Customers.Clear();
                foreach (var c in customers)
                {
                    Customers.Add(new CustomerViewModel(c));
                }
               
            
        }

        /// Queries the database for a current list of customers.
        public void Sync()
        {

            Task.Run(async () =>
            {
              
                foreach (var modifiedCustomer in Customers
                    .Where(customer => customer.IsModified).Select(customer => customer.Model))
                {
                    await App.Repository.Customers.UpsertAsync(modifiedCustomer);
                }

                await GetCustomerListAsync();
               
            });


        }
    }
}
