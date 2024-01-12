using CRM.Infrasctructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application.Customer.Commands
{
    public class CreateCustomerCommand
    {
        private readonly CRMMemoryPersistenceService _cRMMemoryPersistenceService;  
        public CreateCustomerCommand(CRMMemoryPersistenceService cRMMemoryPersistenceService)
        {
            _cRMMemoryPersistenceService = cRMMemoryPersistenceService;
        }

        public void Execute(Domain.Customer customer)
        {
            _cRMMemoryPersistenceService.Customers.Add(customer);
        }
    }
}
