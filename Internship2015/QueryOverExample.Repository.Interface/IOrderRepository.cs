﻿using System.Collections.Generic;
using QueryOverExample.Domain.Model;
using QueryOverExample.Domain.Model.Rows;

namespace QueryOverExample.Repository.Interface
{
    public interface IOrderRepository
    {
        IList<Order> GetAll();
        IList<Client> GetClientOrderByFirstname(string firstname);
        IList<Client> GetClientByOrderNumber(string orderNumber);
        IList<string> GetAllOrderNumbers();
        IList<OrderDetailsRow> GetAllOrderDetailsRows();
        IList<OrderDetailsRow> GetAllClientOrderDetailsRows_1();
        IList<OrderDetailsRow> GetAllClientOrderDetailsRows_2();

        IList<ClientWithOrdersCountsRow> GetClientsWithOrdersCountsRows();
        IList<ClientWithOrdersCountsRow> GetClientRowsHavingMoreThanOneOrder();
    }
}