using CRM.Domain;
using CRM.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application.Customer
{
    public class CustomerDTO
    {
        public string CompanyName { get; set; }
        public EnumCustomerType Type { get; set; }
    }
}
