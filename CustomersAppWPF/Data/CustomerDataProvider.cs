using CustomersAppWPF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomersAppWPF.Data
{
    public interface ICustomerDataProvider
    {
        Task<IEnumerable<Customer>?> GetAllAsync();
    }
    public class CustomerDataProvider : ICustomerDataProvider
    {
        public async Task<IEnumerable<Customer>?> GetAllAsync()
        {
            await Task.Delay(100);

            return new List<Customer>
            {
                new Customer{Id=1, FirstName="Julia", LastName="Developer", IsDeveloper=true},
                new Customer{Id=2, FirstName="Alex", LastName="Der"},
                new Customer{Id=3, FirstName="Thomas", LastName="Deper", IsDeveloper=true},
                new Customer{Id=4, FirstName="Anna", LastName="Evel"},
                new Customer{Id=5, FirstName="John", LastName="Loper"},
                new Customer{Id=6, FirstName="Sara", LastName="Dev"}
            };
        }
    }
}
