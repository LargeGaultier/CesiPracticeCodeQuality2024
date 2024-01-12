using CRM.Domain;
using CRM.Domain.Enum;
using CRM.Infrasctructure.Persistence;
using CRM.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application.Customer.Commands
{
    public class TransformPropectToCustomerCommand
    {
        private readonly IPersistenceService persistenceService;
        public TransformPropectToCustomerCommand(IPersistenceService persistenceService)
        {
            this.persistenceService = persistenceService;
        }

        public void Execute(Domain.Customer customer)
        {
            if (customer.Type == EnumCustomerType.Prospect)
            {
                if (customer.Quotations.Any(quotation => quotation.QuotationStatus == EnumQuotationStatus.accepted)
                    && customer.Contacts.SelectMany(x => x.CustomerSaleContacts)
                    .Any(customerSaleContact => customerSaleContact.DateContact > DateTime.Now.AddDays(1))) ;
                {
                    customer.Type = EnumCustomerType.Customer;
                }
            }
        }
    }
}
