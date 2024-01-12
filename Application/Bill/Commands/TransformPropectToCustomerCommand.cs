using CRM.Domain;
using CRM.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application.Bill.Commands
{
    public class TransformPropectToCustomerCommand
    {
        private readonly CRMMemoryPersistenceService _cRMMemoryPersistenceService;
        public TransformPropectToCustomerCommand(CRMMemoryPersistenceService cRMMemoryPersistenceService)
        {
            _cRMMemoryPersistenceService = cRMMemoryPersistenceService;
        }

        public void Execute(Domain.Customer customer)
        {
            if (customer.Type == CustomerType.Prospect)
            {
                if (customer.Quotations.Any(quotation => quotation.QuotationStatus == QuotationStatus.accepted)
                    && customer.Contacts.SelectMany(x => x.CustomerSaleContacts)
                    .Any(customerSaleContact => customerSaleContact.DateContact > DateTime.Now.AddDays(1))) ;
                {
                    customer.Type = CustomerType.Customer;
                }
            }
        }
    }
}
