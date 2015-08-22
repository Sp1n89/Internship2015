using System.Collections.Generic;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Transform;
using QueryOverExample.Domain.Model;
using QueryOverExample.Repository.Interface;
using Order = QueryOverExample.Domain.Model.Order;

namespace QueryOverExample.Repository
{
    public class ClientRepository : IClientRepository
    {
        private readonly ISession _session;

        public ClientRepository(ISession session)
        {
            _session = session;
        }

        public IList<Client> GetAll()
        {
            return _session.QueryOver<Client>().List();
        }

        public IList<Client> GetByFirstname(string firstname)
        {
            return _session.QueryOver<Client>().Where(c => c.Firstname == firstname).List();
        }

        public IList<string> GetClientLastnameByFirstname(string firstname)
        {
            return _session.QueryOver<Client>()
                .Where(c => c.Firstname == firstname)
                .Select(c => c.Lastname)
                .List<string>();
        }

        public string GetClientLastnameById(int clientId)
        {
            return _session.QueryOver<Client>()
                .Where(c => c.Id == clientId)
                .Select(c => c.Lastname)
                .SingleOrDefault<string>();
        }

        public IList<object[]> GetAllFirstAndLastNames_SelectList()
        {
            return _session.QueryOver<Client>()
                .SelectList(list => list
                    .Select(c => c.Firstname)
                    .Select(c => c.Lastname))
                .List<object[]>();
        }

        public IList<object[]> GetAllFirstAndLastNames_ProjectionList()
        {
            Client client = null;

            return _session.QueryOver(() => client)
                .Select(Projections.ProjectionList()
                    .Add(Projections.Property(() => client.Firstname))
                    .Add(Projections.Property(() => client.Lastname)))
                .List<object[]>();
        }

        public IList<Client> GetAllClientsWithOrders()
        {
            Client client = null;
            Order order = null;

            return _session.QueryOver(() => client)
                .JoinAlias(c => c.Orders, () => order)
                .List<Client>();
        }

        public IList<Client> GetAllClientsWithOrders_Distinct()
        {
            Client client = null;
            Order order = null;

            return _session.QueryOver(() => client)
                .JoinAlias(() => client.Orders, () => order)
                .TransformUsing(Transformers.DistinctRootEntity)
                .List<Client>();
        }
    }
}