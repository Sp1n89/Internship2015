using FluentNHibernate.Mapping;

namespace QueryOverExample.Domain.Model.Mapping
{
    public class ClientMap : ClassMap<Client>
    {
        public ClientMap()
        {
            Table("Client");
            Id(x => x.Id).Column("ClientID").GeneratedBy.Identity();

            Map(x => x.Firstname).Not.Nullable();
            Map(x => x.Lastname).Not.Nullable();
            Map(x => x.TelephoneNumber);
            Map(x => x.Address);

            HasMany(x => x.Orders).Inverse().KeyColumn("ClientID");
        }
    }
}