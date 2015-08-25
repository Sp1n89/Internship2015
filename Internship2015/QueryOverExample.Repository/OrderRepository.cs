﻿using System.Collections.Generic;
using NHibernate;
using NHibernate.SqlCommand;
using NHibernate.Transform;
using QueryOverExample.Domain.Model;
using QueryOverExample.Domain.Model.Rows;
using QueryOverExample.Repository.Interface;

namespace QueryOverExample.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ISession _session;

        public OrderRepository(ISession session)
        {
            _session = session;
        }

        public IList<Order> GetAll()
        {
            return _session.QueryOver<Order>().List();
        }

        public IList<Client> GetClientOrderByFirstname(string firstname)
        {
            return _session.QueryOver<Order>()
                .JoinQueryOver(ord => ord.Client)
                .Where(c => c.Firstname == firstname)
                .Select(c => c.Client)
                .List<Client>();
        }

        public IList<Client> GetClientByOrderNumber(string orderNumber)
        {
            // Aliases
            Client client = null;
            Shop shop = null;

            return _session.QueryOver<Order>()
                .JoinAlias(ord => ord.Client, () => client)
                .JoinAlias(ord => ord.Shop, () => shop)
                .Where(ord => ord.Number == orderNumber)
                .Select(ord => ord.Client)
                .List<Client>();
        }

        public IList<string> GetAllOrderNumbers()
        {
            return _session.QueryOver<Order>()
                .Select(ord => ord.Number)
                .List<string>();
        }

        public IList<OrderDetailsRow> GetAllOrderDetailsRows()
        {
            Order order = null;
            OrderItem orderItem = null;
            Product product = null;
            Client client = null;

            OrderDetailsRow row = null;

            return _session.QueryOver(() => order)
                .JoinAlias(() => order.Client, () => client)
                .JoinAlias(() => order.Items, () => orderItem)
                .JoinAlias(() => orderItem.Product, () => product)
                .SelectList(list => list
                    .Select(() => order.Number).WithAlias(() => row.OrderNumber)
                    .Select(() => client.Firstname).WithAlias(() => row.Firstname)
                    .Select(() => client.Lastname).WithAlias(() => row.Lastname)
                    .Select(() => client.TelephoneNumber).WithAlias(() => row.TelephoneNumber)
                    .Select(() => product.Name).WithAlias(() => row.Product)
                    .Select(() => product.ProductCategory).WithAlias(() => row.ProductCategory))
                .TransformUsing(Transformers.AliasToBean<OrderDetailsRow>())
                .List<OrderDetailsRow>();
        }

        public IList<OrderDetailsRow> GetAllClientOrderDetailsRows_1()
        {
            Order order = null;
            OrderItem orderItem = null;
            Product product = null;
            Client client = null;

            OrderDetailsRow row = null;

            return _session.QueryOver(() => order)
                .Left.JoinAlias(() => order.Client, () => client)
                .JoinAlias(() => order.Items, () => orderItem)
                .JoinAlias(() => orderItem.Product, () => product)
                .SelectList(list => list
                    .Select(() => order.Number).WithAlias(() => row.OrderNumber)
                    .Select(() => client.Firstname).WithAlias(() => row.Firstname)
                    .Select(() => client.Lastname).WithAlias(() => row.Lastname)
                    .Select(() => client.TelephoneNumber).WithAlias(() => row.TelephoneNumber)
                    .Select(() => product.Name).WithAlias(() => row.Product)
                    .Select(() => product.ProductCategory).WithAlias(() => row.ProductCategory))
                .TransformUsing(Transformers.AliasToBean<OrderDetailsRow>())
                .List<OrderDetailsRow>();
        }

        public IList<OrderDetailsRow> GetAllClientOrderDetailsRows_2()
        {
            Order order = null;
            OrderItem orderItem = null;
            Product product = null;
            Client client = null;

            OrderDetailsRow row = null;

            return _session.QueryOver(() => order)
                .JoinAlias(() => order.Client, () => client, JoinType.LeftOuterJoin)
                .JoinAlias(() => order.Items, () => orderItem)
                .JoinAlias(() => orderItem.Product, () => product)
                .SelectList(list => list
                    .Select(() => order.Number).WithAlias(() => row.OrderNumber)
                    .Select(() => client.Firstname).WithAlias(() => row.Firstname)
                    .Select(() => client.Lastname).WithAlias(() => row.Lastname)
                    .Select(() => client.TelephoneNumber).WithAlias(() => row.TelephoneNumber)
                    .Select(() => product.Name).WithAlias(() => row.Product)
                    .Select(() => product.ProductCategory).WithAlias(() => row.ProductCategory))
                .TransformUsing(Transformers.AliasToBean<OrderDetailsRow>())
                .List<OrderDetailsRow>();
        }
    }
}