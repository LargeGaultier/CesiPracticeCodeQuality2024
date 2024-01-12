using CRM.Shared.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Domain
{
    public class Adress : BaseEntity
    {
        public string AdressType { get; set; }
        public string Street { get; set; }
        public string StreetNumber { get; set; }
        public int ZipCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public Customer? Customer { get; set; }
        public Contact? Contact { get; set;}
    }
}
