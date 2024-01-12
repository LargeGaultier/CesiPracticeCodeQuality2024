using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Domain
{
    public class CustomerSaleContact
    {
        public int Id { get; set; }
        public DateTime DateContact { get; set; }
        public string Description { get; set; }
        public Contact Customer { get; set; }
    }
}
