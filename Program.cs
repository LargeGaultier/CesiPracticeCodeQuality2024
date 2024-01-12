
// See https://aka.ms/new-console-template for more information
using CRM.Application.Customer.Commands;
using CRM.Application.Customer.Queries;
using CRM.Domain;
using CRM.Infrasctructure.Persistence;
using CRM.Infrasctructure.Persistence.repositories;
using CRM.Shared.Interfaces;
using System.Text;

Console.WriteLine("WelCome To my CRM");




IPersistenceService persistenceService = new PersistenceService(new CustomerRepository());
CreateCustomerCommand createCustomerCommand = new CreateCustomerCommand(persistenceService);

createCustomerCommand.Execute(new CRM.Application.Customer.CustomerDTO()
{
    CompanyName = "Mon Client",
    Type = CRM.Domain.Enum.EnumCustomerType.Customer

}) ;



GetCustomerNumberQuery getCustomerNumberQuery = new GetCustomerNumberQuery(persistenceService);
var nbCustomer = getCustomerNumberQuery.Execute();

Console.WriteLine($"Le nombre de clienst est de {nbCustomer}");


