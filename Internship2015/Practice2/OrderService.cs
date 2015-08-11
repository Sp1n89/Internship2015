using System;

namespace Practice2
{
    public class OrderService
    {
        private readonly IDataAccess _dataAccess;

        private readonly IRegisterOrderService _registerOrderService;

        public OrderService(IDataAccess dataAccess, IRegisterOrderService registerOrderService)
        {

            _dataAccess = dataAccess;

            _registerOrderService = registerOrderService;

        }

        public void RegisterOrder(string customerName, string productName)
        {

            if (customerName == null)

                throw new ArgumentNullException("customerName");

            if (productName == null)

                throw new ArgumentNullException("productName");

            if (AntiHackUtility.InputStringsAreHacked(customerName, productName))

                throw new ApplicationHackException();

            var customer = _dataAccess.FindCustomerByName(customerName);

            var product = _dataAccess.FindProductByName(productName);

            _registerOrderService.CreateOrder(customer, product);

        }

    }
}