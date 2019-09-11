using System.Collections.Generic;
using CIMS2019.EF.Domain;

namespace CIMS2019.Services
{
    public interface ICustomerService
    {
        Customer GetCustomerById(int id, bool refreshCache = false);
        Customer GetCustomerByLoginName(string loginname);
        IList<Customer> GetCustomersByIds(int[] Ids);
        IList<Customer> GetAllCustomers();
        Customer InsertCustomer(Customer customer);
        Customer UpdateCustomer(Customer customer);
    }
}
