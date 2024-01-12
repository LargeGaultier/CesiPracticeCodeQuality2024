using CRM.Domain;
using CRM.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Infrasctructure.Persistence.repositories
{
    public class CustomerRepository : IRepository<Customer>
    {
        
        private readonly List<Customer> _customerList;


        public CustomerRepository()
        {
            _customerList = new List<Customer>();
        }
       
        public List<Customer> GetAll()
        {
            return _customerList;
        }
        //AddCustomer
        public Customer Add(Customer customer)
        {
            if (_customerList.Any())
            {
                customer.Id = _customerList.Max(x => x.Id) + 1;
            }
            else
            {
                customer.Id = 1;
            }
            _customerList.Add(customer);
            return customer;
        }

        public Customer? GetById(int id)
        {
            return _customerList.FirstOrDefault(x => x.Id == id);
        }

        public Customer Update(Customer customer)
        {

            var exisingCustomer = GetById(customer.Id);
            if (exisingCustomer != null)
            {
                exisingCustomer = customer;
                return customer;
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        public bool Remove(Customer customer)
        {
            Customer? toDelete = _customerList.FirstOrDefault(
                x => x.Id == customer.Id);
            if (toDelete != null)
            {
                _customerList.Remove(toDelete);
            }
            else
            {
                throw new InvalidOperationException();
            }
            return true;
        }
    }
}
