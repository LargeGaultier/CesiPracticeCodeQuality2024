using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Domain
{
    public class Bill
    {

        public Bill()
        {
           
        }
        public int Id { get; set; }
        public DateTime DateCreation { get; set; }
        public string BillNumber { get; set; }
        public string BillType { get; set; }
        public string BillStatus { get; set; }
        public PaiementStatus BillPaymentStatus { get; set; }
        public decimal amount { get; set; }
        public OfferType OfferType { get; set; }
        public Customer Customer { get; set; }
        public Quotation Quotation { get; set; }
    }

    public enum PaiementStatus
    {
        paid,
        unpaid
    }
    public enum  OfferType
    {
        OneTime,
        Subscription

    }
}
