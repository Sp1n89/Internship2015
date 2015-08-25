using Microsoft.Practices.Unity;
using QueryOverExample.Repository;
using QueryOverExample.Repository.Interface;

namespace QueryOverExample.Infrastructure
{
    public static class IoC
    {
        private static readonly UnityContainer Container;

        static IoC()
        {
            if (Container == null)
            {
                Container = new UnityContainer();
            }
        }

        public static void RegisterAll()
        {
            Container.RegisterType<IClientRepository, ClientRepository>();
            Container.RegisterType<IOrderRepository, OrderRepository>();
            Container.RegisterType<IShopRepository, ShopRepository>();
            Container.RegisterInstance(NHibernateProvider.GetSession());
        }

        public static T Resolve<T>()
        {
            return Container.Resolve<T>();
        }
    }
}