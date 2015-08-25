using System;
using QueryOverExample.Infrastructure;
using QueryOverExample.Repository.Interface;

namespace QueryOverExample.Presentation
{
    public class Program
    {
        private static readonly IClientRepository ClientRepository;
        private static readonly IOrderRepository OrderRepository;

        static Program()
        {
            IoC.RegisterAll();

            ClientRepository = IoC.Resolve<IClientRepository>();
            OrderRepository = IoC.Resolve<IOrderRepository>();
        }

        static void Main()
        {

            //// QueryOver Basic
            //ShowAllClients();

            //// Where
            //ShowClientsByFirstname("John");

            //// JoinQueryOver
            //ShowClientsOrderByFirstname("Kenneth");


            //// JoinAlias
            //ShowClientsOrdersByOrderNumber("4556374220020977");

            //// Where & Selecting
            //ShowClientLastnameByFirstname("Allen");

            //// Left Join
            //ShowAllClientOrderDetailsRows_1();
            //ShowAllClientOrderDetailsRows_2();

            //// Selecting property SingleOrDefault
            //ShowClientLastnameById(5);

            //// Selecting property list
            //ShowAllOrderNumbers();

            //// Selecting multiple properties using SelectList
            //ShowAllClientsFirstAndLastNames_SelectList();

            //// Selecting multiple properties using ProjectionList
            //ShowAllClientsFirstAndLastNames_ProjectionList();

            //// Transformers
            //ShowAllClientsWithOrdersCount();

            //// DistinctRootEntity Transformer
            //ShowAllClientsWithOrders_DistinctCount();

            //// AliasToBean Transformer
            //ShowAllOrderDetails();

            //// Select GroupBy
            //ShowClientsWithOrdersCountsRows();

            //// Select GroupBy and Having
            //ShowClientRowsHavingMoreThanOneOrder();

            Console.ReadLine();
        }

        private static void ShowAllClients()
        {
            var clients = ClientRepository.GetAll();
            clients.PrintToConsole();
        }

        private static void ShowClientsByFirstname(string firstname)
        {
            var clients = ClientRepository.GetByFirstname(firstname);
            clients.PrintToConsole();
        }

        private static void ShowClientsOrderByFirstname(string firstname)
        {
            var clients = OrderRepository.GetClientOrderByFirstname(firstname);
            clients.PrintToConsole();
        }

        private static void ShowClientsOrdersByOrderNumber(string orderNumber)
        {
            var clients = OrderRepository.GetClientByOrderNumber(orderNumber);
            clients.PrintToConsole();
        }

        private static void ShowClientLastnameByFirstname(string firstname)
        {
            var clients = ClientRepository.GetClientLastnameByFirstname(firstname);
            clients.PrintToConsole();
        }

        private static void ShowClientLastnameById(int clientId)
        {
            var lastname = ClientRepository.GetClientLastnameById(clientId);
            Console.WriteLine(lastname);
        }

        private static void ShowAllOrderNumbers()
        {
            var numbers = OrderRepository.GetAllOrderNumbers();
            numbers.PrintToConsole();
        }

        private static void ShowAllClientsFirstAndLastNames_SelectList()
        {
            var clients = ClientRepository.GetAllFirstAndLastNames_SelectList();
            foreach (var client in clients)
            {
                Console.WriteLine("{0} {1}", client[0], client[1]);
            }
        }

        private static void ShowAllClientsFirstAndLastNames_ProjectionList()
        {
            var clients = ClientRepository.GetAllFirstAndLastNames_ProjectionList();
            foreach (var client in clients)
            {
                Console.WriteLine("{0} {1}", client[0], client[1]);
            }
        }

        private static void ShowAllClientsWithOrdersCount()
        {
            var clients = ClientRepository.GetAllClientsWithOrders();

            Console.WriteLine("There are {0} client records with orders", clients.Count);
        }

        private static void ShowAllClientsWithOrders_DistinctCount()
        {
            var clients = ClientRepository.GetAllClientsWithOrders_Distinct();

            Console.WriteLine("There are {0} client records with orders", clients.Count);
        }

        private static void ShowAllOrderDetails()
        {
            var orderDetails = OrderRepository.GetAllOrderDetailsRows();
            foreach (var row in orderDetails)
            {
                Console.WriteLine("{0}, {1} {2} {3}, {4} {5}", row.OrderNumber, row.Firstname, row.Lastname,
                    row.TelephoneNumber, row.Product, row.Category);
            }
        }

        private static void ShowAllClientOrderDetailsRows_1()
        {
            var clients = OrderRepository.GetAllClientOrderDetailsRows_1();
            Console.WriteLine("{0, -20} {1, -20} {2, -20} {3, -20} {4, -50} {5, -20}", "Order Number", "Firstname",
                "Lastname", "Telephone Number", "Product", "Category");

            foreach (var row in clients)
            {
                Console.WriteLine(row);
            }
        }

        private static void ShowAllClientOrderDetailsRows_2()
        {
            var clients = OrderRepository.GetAllClientOrderDetailsRows_2();
            Console.WriteLine("{0, -20} {1, -20} {2, -20} {3, -20} {4, -50} {5, -20}", "Order Number", "Firstname",
                "Lastname", "Telephone Number", "Product", "Category");

            foreach (var row in clients)
            {
                Console.WriteLine(row);
            }
        }

        private static void ShowClientsWithOrdersCountsRows()
        {
            const string template = "{0, -15} {1, -15} {2, -15} {3, -15}";
            var clients = OrderRepository.GetClientsWithOrdersCountsRows();
            
            Console.WriteLine(template, "ClientID", "Firstname", "Lastname", "Orders");

            foreach (var row in clients)
            {
                Console.WriteLine(row);
            }
        }

        private static void ShowClientRowsHavingMoreThanOneOrder()
        {
            const string template = "{0, -15} {1, -15} {2, -15} {3, -15}";
            var clients = OrderRepository.GetClientRowsHavingMoreThanOneOrder();

            Console.WriteLine(template, "ClientID", "Firstname", "Lastname", "Orders");

            foreach (var row in clients)
            {
                Console.WriteLine(row);
            }
        }

    }
}
