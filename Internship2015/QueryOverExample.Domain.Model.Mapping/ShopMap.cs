using FluentNHibernate.Mapping;

namespace QueryOverExample.Domain.Model.Mapping
{
    public class ShopMap : ClassMap<Shop>
    {
        public ShopMap()
        {
            Table("Shop");
            Id(x => x.Id).Column("ShopID").GeneratedBy.Identity();

            Map(x => x.Name).Not.Nullable();
            Map(x => x.Address);

            HasMany(x => x.Products).Inverse().KeyColumn("ShopID");
        }
    }
}