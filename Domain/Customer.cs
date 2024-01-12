using CRM.Domain.Enum;
using CRM.Shared.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Domain
{
    public class Customer : BaseEntity
    {
        //constructeur paremetré
        public Customer(string companyName, EnumCustomerType type)
        {
            CompanyName = companyName;
            Type = type;
        }
        

        public string CompanyName { get; set; }
        
        public EnumCustomerType Type { get; set; }

        public List<Contact> Contacts { get; set; }
        public List<Adress> Adresses { get; set; }  
        public List<Quotation> Quotations { get; set; }
        public List<Bill> Bills { get; set; }

    }

    

   
}
