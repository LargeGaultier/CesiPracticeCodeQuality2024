using CRM.Domain;
using CRM.Infrasctructure.Persistence.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Shared.Interfaces
{
    public interface IPersistenceService
    {
        IRepository<Customer> CustomerRepository { get; set; }
    }
}
