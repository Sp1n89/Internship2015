using FluentNHibernate.Mapping;

namespace QueryOverExample.Domain.Model.Mapping
{
    public class OrderMap : ClassMap<Order>
    {
        public OrderMap()
        {
            Table("ClientOrder");
            Id(x => x.Id).Column("ClientOrderID").GeneratedBy.Identity();

            Map(x => x.Number).Not.Nullable();
            Map(x => x.CreatedDate).Not.Nullable();

            References(x => x.Shop).Column("ShopID").ForeignKey("Order_Shop_ShopID").Not.Nullable();
            References(x => x.Client).Column("ClientID").ForeignKey("Order_Client_ClientID").Not.Nullable();

            HasMany(x => x.Items).Inverse().KeyColumn("OrderID");
        }
    }
}