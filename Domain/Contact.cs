using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Domain
{
    public class Contact
    {
        //constructeur parametré
        public Contact(string firstName, string lastName, string email, string phone)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.Phone = phone;
          

        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Customer Customer { get; set; }
        public List<Adress> Adresses { get; set; }
        public List<CustomerSaleContact> CustomerSaleContacts { get; set; }

    }
}
