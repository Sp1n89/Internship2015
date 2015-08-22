using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using QueryOverExample.Domain.Model.Mapping;

namespace QueryOverExample.Infrastructure
{
    public static class NHibernateProvider
    {
        private const string ConnectionStringName = "HomeConnectionString";
//        private const string ConnectionStringName = "WorkConnectionString";

        static NHibernateProvider()
        {
            if (_sessionFactory == null)
            {
                _sessionFactory = CreateSessionFactory();
            }
        }

        private static ISessionFactory _sessionFactory;

        public static ISession GetSession()
        {
            if (_sessionFactory == null)
            {
                _sessionFactory = CreateSessionFactory();
            }
            return _sessionFactory.OpenSession();
        }

        private static ISessionFactory CreateSessionFactory()
        {
            var configuration = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2012
                    .ConnectionString(c => c.FromConnectionStringWithKey(ConnectionStringName)))
                .Mappings(x => x.FluentMappings.AddFromAssembly(typeof (ProductMap).Assembly))
                .ExposeConfiguration(cfg => new SchemaUpdate(cfg).Execute(false, true));

            return configuration.BuildSessionFactory();
        }
    }
}
