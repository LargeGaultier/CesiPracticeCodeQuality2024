using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application.Bill.Queries
{
    public class IsAllBillForCustomerArePayed
    {

        public bool Execute(Domain.Customer customer)
        {
            return customer.Bills.All(x => x.BillPaymentStatus == Domain.PaiementStatus.paid);
        }
    }
}
