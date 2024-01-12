using CRM.Infrasctructure.Persistence;
using CRM.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application.Customer.Queries
{
    public class GetCustomerNumberQuery
    {
        private readonly IPersistenceService _persistenceService;
        public GetCustomerNumberQuery(IPersistenceService persistenceService)
        {
            _persistenceService = persistenceService;
        }

        public int Execute()
        {
            return _persistenceService.CustomerRepository.GetAll().Count(x=> x.Type != Domain.Enum.EnumCustomerType.Prospect);
        }
    }
}
