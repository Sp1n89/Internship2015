using System.Collections.Generic;
using System.Linq;
using NHibernate;
using QueryOverExample.Domain.Model;
using QueryOverExample.Repository.Interface;

namespace QueryOverExample.Repository
{
    public class ShopRepository : IShopRepository
    {
        private readonly ISession _session;

        public ShopRepository(ISession session)
        {
            _session = session;
        }
        
    }
}