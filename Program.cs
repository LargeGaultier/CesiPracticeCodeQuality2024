
// See https://aka.ms/new-console-template for more information
using CRM.Application.Customer.Queries;
using CRM.Domain;
using CRM.Infrasctructure.Persistence;
using System.Text;

Console.WriteLine("Hello, World!");


CRMMemoryPersistenceService cRMMemoryPersistenceService = new();

GetCustomerNumberQuery getCustomerNumberQuery = new GetCustomerNumberQuery(cRMMemoryPersistenceService);
var nbCustomer = getCustomerNumberQuery.Execute();




