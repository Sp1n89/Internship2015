using System.Collections;
using System.Collections.Generic;
using QueryOverExample.Domain.Model;

namespace QueryOverExample.Repository.Interface
{
    public interface IClientRepository
    {
        IList<Client> GetAll();
        IList<Client> GetByFirstname(string firstname);
        IList<string> GetClientLastnameByFirstname(string firstname);
        string GetClientLastnameById(int clientId);
        IList<object[]> GetAllFirstAndLastNames_SelectList();
        IList<object[]> GetAllFirstAndLastNames_ProjectionList();
        IList<Client> GetAllClientsWithOrders();
        IList<Client> GetAllClientsWithOrders_Distinct();
    }
}
