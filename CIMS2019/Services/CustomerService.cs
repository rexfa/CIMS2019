using System;
using System.Collections.Generic;
using System.Linq;
using CIMS2019.EF;
using CIMS2019.EF.Domain;

namespace CIMS2019.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly MysqlContext _mysqlContext;
        private readonly EfRepository<Customer> _customerRepository;

        public CustomerService(MysqlContext mysqlContext)
        {
            this._mysqlContext = mysqlContext;
            this._customerRepository = new EfRepository<Customer>(this._mysqlContext);
        }
        public IList<Customer> GetAllCustomers()
        {
            throw new System.NotImplementedException();
        }

        public Customer GetCustomerById(int id, bool refreshCache = false)
        {
            throw new System.NotImplementedException();
        }

        public Customer GetCustomerByLoginName(string loginname)
        {
            return _customerRepository.Table.Where(c => c.LoginName.Equals(loginname.Trim())).FirstOrDefault();
        }
        Customer GetCustomerByIDNumber(string idNumber)
        {
            return _customerRepository.Table.Where(c => c.IDNumber.Equals(idNumber.Trim())).FirstOrDefault();
        }
        public IList<Customer> GetCustomersByIds(int[] Ids)
        {
            throw new System.NotImplementedException();
        }

        public Customer InsertCustomer(Customer customer)
        {
            _customerRepository.Insert(customer);
            _mysqlContext.SaveChanges();
            return customer;
        }

        public Customer UpdateCustomer(Customer customer)
        {
            throw new System.NotImplementedException();
        }
    }
}
