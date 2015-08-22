using System;
using System.Collections.Generic;

namespace QueryOverExample.Domain.Model
{
    public class Order : EntityBase
    {
        protected Order()
        {
            Items = new List<OrderItem>();
        }

        public Order(string number, Shop shop, Client client) : this()
        {
            Number = number;
            Shop = shop;
            Client = client;
        }

        public virtual string Number { get; set; }

        public virtual Shop Shop { get; set; }

        public virtual Client Client { get; set; }

        public virtual DateTime CreatedDate { get; set; }

        public virtual IList<OrderItem> Items { get; set; }
    }
}