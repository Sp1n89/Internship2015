namespace QueryOverExample.Domain.Model
{
    public class OrderItem : EntityBase
    {
        protected OrderItem()
        {
            
        }

        public OrderItem(Product product, Order order)
        {
            Product = product;
            Order = order;
        }

        public virtual Product Product { get; set; }

        public virtual Order Order { get; set; }
    }
}