using CRM.Infrasctructure.Persistence;
using CRM.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application.Customer.Commands
{
    public class CreateCustomerCommand
    {
        private readonly IPersistenceService _cRMMemoryPersistenceService;  
        public CreateCustomerCommand(IPersistenceService cRMMemoryPersistenceService)
        {
            _cRMMemoryPersistenceService = cRMMemoryPersistenceService;
        }

        public void Execute(CustomerDTO customerToAdd)
        {
            _cRMMemoryPersistenceService.CustomerRepository.Add(
                new Domain.Customer(customerToAdd.CompanyName, customerToAdd.Type));
        }
    }
}
