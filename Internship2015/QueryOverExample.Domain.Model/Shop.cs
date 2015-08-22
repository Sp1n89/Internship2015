using System.Collections.Generic;

namespace QueryOverExample.Domain.Model
{
    public class Shop : EntityBase
    {
        protected Shop()
        {
            Products = new List<ShopProduct>();
        }

        public Shop(string name, string address) : this()
        {
            Name = name;
            Address = address;
        }

        public virtual string Name { get; set; }

        public virtual string Address { get; set; }

        public virtual IList<ShopProduct> Products { get; protected set; }
    }
}