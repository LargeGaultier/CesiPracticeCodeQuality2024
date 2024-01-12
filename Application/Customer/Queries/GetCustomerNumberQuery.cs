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
        private readonly PersistenceService _persistenceService;
        public GetCustomerNumberQuery(PersistenceService persistenceService)
        {
            _persistenceService = persistenceService;
        }

        public int Execute()
        {
            return _persistenceService.CustomerRepository.GetAll().Count(x=> x.Type != Domain.Enum.EnumCustomerType.Prospect);
        }
    }
}
