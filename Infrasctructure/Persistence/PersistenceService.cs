using CRM.Domain;
using CRM.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Infrasctructure.Persistence
{
    public class PersistenceService : IPersistenceService
    {
     
        public PersistenceService(IRepository<Customer> customerRepository)
        {
          CustomerRepository = customerRepository;
        }
        public IRepository<Customer> CustomerRepository { get; set;}
    }
}
