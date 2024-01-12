using CRM.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Infrasctructure.Persistence
{
    public class CRMMemoryPersistenceService
    {
        //Contructeur
        public CRMMemoryPersistenceService()
        {
            Bills = new List<Bill>();
            Contacts = new List<Contact>();
            Customers = new List<Customer>();
            Quotations = new List<Quotation>();
            Adresses = new List<Adress>();
            CustomerSaleContacts = new List<CustomerSaleContact>();
        }

        public List<Bill> Bills { get; set; }
        public List<Contact> Contacts { get; set; }
        public List<Customer> Customers { get; set; }
        public List<Quotation> Quotations { get; set; }
        public List<Adress> Adresses { get; set; }
        public List<CustomerSaleContact> CustomerSaleContacts { get; set; }
    }
}
