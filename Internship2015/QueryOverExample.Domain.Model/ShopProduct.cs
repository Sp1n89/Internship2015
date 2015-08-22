namespace QueryOverExample.Domain.Model
{
    public class ShopProduct : EntityBase
    {
        protected ShopProduct()
        {
            
        }

        public ShopProduct(Shop shop, Product product)
        {
            Shop = shop;
            Product = product;
        }

        public virtual Shop Shop { get; set; }

        public virtual Product Product { get; set; }

        public virtual decimal Price { get; set; }
    }
}