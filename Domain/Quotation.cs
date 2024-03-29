﻿using CRM.Domain.Enum;
using CRM.Shared.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Domain
{
    public class Quotation : BaseEntity
    {
        public DateTime DateCreation { get; set; }
        public string QuotationNumber { get; set; }
        public string QuotationType { get; set; }
        public EnumQuotationStatus QuotationStatus { get; set; }
        public decimal Amount { get; set; }
        public OfferType OfferType { get; set; }
        
        public Customer Customer { get; set; }

        
    }
 
}
