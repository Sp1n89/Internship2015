using FluentNHibernate.Mapping;

namespace QueryOverExample.Domain.Model.Mapping
{
    public class ShopProductMap : ClassMap<ShopProduct>
    {
        public ShopProductMap()
        {
            Table("ShopProduct");
            Id(x => x.Id).Column("ShopProductID").GeneratedBy.Identity();

            Map(x => x.Price).Not.Nullable().Default("0.0");

            References(x => x.Shop).Column("ShopID").ForeignKey("ShopProduct_Shop_ShopID").Not.Nullable();
            References(x => x.Product).Column("ProductID").ForeignKey("ShopProduct_Product_ProductID").Not.Nullable();
        }
    }
}