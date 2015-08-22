using NHibernate;
using NUnit.Framework;
using QueryOverExample.Domain.Model;
using QueryOverExample.Infrastructure;

namespace QueryOverExample.Tests
{
    [TestFixture]
    public class DbTest
    {
        private ISession _session;

        [SetUp]
        public void InitializeData()
        {
            _session = NHibernateProvider.GetSession();
        }

        [Test]
        public void CanCreateClient()
        {
            var result = _session.QueryOver<Client>().List<Client>();

            Assert.AreEqual(1, result.Count);
        }

        [TearDown]
        public void TearDown()
        {
            if (_session != null && _session.IsOpen)
            {
                _session.Dispose();
            }
        }

    }
}
