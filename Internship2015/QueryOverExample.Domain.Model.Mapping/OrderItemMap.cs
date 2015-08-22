using FluentNHibernate.Mapping;

namespace QueryOverExample.Domain.Model.Mapping
{
    public class OrderItemMap : ClassMap<OrderItem>
    {
        public OrderItemMap()
        {
            Table("OrderItem");
            Id(x => x.Id).Column("OrderItemID").GeneratedBy.Identity();

            References(x => x.Product).Column("ProductID").ForeignKey("OrderItem_Product_ProductID").Not.Nullable();
            References(x => x.Order).Column("OrderID").ForeignKey("OrderItem_Order_OrderID").Not.Nullable();
        }
    }
}