using CRM.Infrasctructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application.Customer.Queries
{
    public class GetCustomerNumberQuery
    {
        private readonly CRMMemoryPersistenceService _cRMMemoryPersistenceService;
        public GetCustomerNumberQuery(CRMMemoryPersistenceService cRMMemoryPersistenceService)
        {
            _cRMMemoryPersistenceService = cRMMemoryPersistenceService;
        }

        public int Execute()
        {
            return _cRMMemoryPersistenceService.Customers.Count(x=> x.Type != Domain.CustomerType.Prospect);
        }
    }
}
