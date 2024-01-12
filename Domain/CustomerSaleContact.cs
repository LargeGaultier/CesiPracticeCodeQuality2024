using CRM.Shared.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Domain
{
    public class CustomerSaleContact : BaseEntity
    {
        public DateTime DateContact { get; set; }
        public string Description { get; set; }
        public Contact Customer { get; set; }
    }
}
