
// See https://aka.ms/new-console-template for more information
using CRM.Application.Customer.Commands;
using CRM.Application.Customer.Queries;
using CRM.Domain;
using CRM.Infrasctructure.Persistence;
using CRM.Infrasctructure.Persistence.repositories;
using CRM.Shared.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System.Text;

Console.WriteLine("WelCome To my CRM");

ServiceCollection services = new ServiceCollection();
services.AddTransient<IPersistenceService, PersistenceService>();
services.AddTransient<IRepository<Customer>, CustomerRepository>();
services.AddTransient<CreateCustomerCommand>();
services.AddTransient<GetCustomerNumberQuery>();


var Container = services.BuildServiceProvider();



IPersistenceService? persistenceService = Container.GetService<IPersistenceService>();
CreateCustomerCommand? createCustomerCommand = Container.GetService<CreateCustomerCommand>();

if(createCustomerCommand != null)
{ 
createCustomerCommand.Execute(new CRM.Application.Customer.CustomerDTO()
{
    CompanyName = "Mon Client",
    Type = CRM.Domain.Enum.EnumCustomerType.Customer
}) ;
}


GetCustomerNumberQuery? getCustomerNumberQuery = Container.GetService<GetCustomerNumberQuery>();
if (getCustomerNumberQuery != null)
{
    var nbCustomer = getCustomerNumberQuery.Execute();

    Console.WriteLine($"Le nombre de clienst est de {nbCustomer}");
}

