﻿using System.Collections.Generic;

namespace QueryOverExample.Domain.Model
{
    public class Client : EntityBase
    {
        protected Client()
        {
            Orders = new List<Order>();            
        }

        public Client(string firstname, string lastname) : this()
        {
            Firstname = firstname;
            Lastname = lastname;
        }
        
        public virtual string Firstname { get; set; }

        public virtual string Lastname { get; set; }

        public virtual string TelephoneNumber { get; set; }

        public virtual string Address { get; set; }

        public virtual IList<Order> Orders { get; set; }

        public override string ToString()
        {
            return string.Format("Name: {0} {1}, Telephone: {2}, Address: {3}", Firstname, Lastname, TelephoneNumber,
                Address);
        }
    }
}