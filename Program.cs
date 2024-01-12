
// See https://aka.ms/new-console-template for more information
using CRM.Domain;
using System.Text;

Console.WriteLine("Hello, World!");



List<Contact> contacts = new List<Contact>();
List<Customer> customers = new List<Customer>();
List<Adress> adresses = new List<Adress>();

List<CustomerSaleContact> customerSaleContacts = new List<CustomerSaleContact>();


// fonction qui permet de savoir si toutes les factures ont été payé pour un client
bool IsAllInvoicePaid(Customer customer)
{
    return customer.Bills.All(bill => bill.BillPaymentStatus == PaiementStatus.paid);
}

int GetNbProspect()
{
    return customers.Count(customer => customer.Type == CustomerType.Prospect);
}

int GetNbClient()
{
    return customers.Count(customer => customer.Type != CustomerType.Prospect);
}

// transforme un propesct en client
void TransformProspectToClient(Customer customer)
{
    if (customer.Type == CustomerType.Prospect)
    {
        if (customer.Quotations.Any(quotation => quotation.QuotationStatus == QuotationStatus.accepted)
            && customer.Contacts.SelectMany(x => x.CustomerSaleContacts)
            .Any(customerSaleContact => customerSaleContact.DateContact > DateTime.Now.AddDays(1)));
        {
            customer.Type = CustomerType.regular;
        }
    }
}

