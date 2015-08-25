using FluentNHibernate.Mapping;

namespace QueryOverExample.Domain.Model.Mapping
{
    public class ProductMap : ClassMap<Product>
    {
        public ProductMap()
        {
            Table("Product");
            Id(x => x.Id).Column("ProductID").GeneratedBy.Identity();

            Map(x => x.Name).Not.Nullable();
            Map(x => x.Category).Not.Nullable();
        }
    }
}
