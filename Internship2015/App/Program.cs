using System;
using System.Collections.Generic;
using Microsoft.Practices.Unity;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new UnityContainer();
            container.RegisterType<IEmployeeBll, EmployeeBll>();
            container.RegisterType<IEmployeeRepository, EmployeeRepository>();

            var bll = container.Resolve<IEmployeeBll>();
            var employees = bll.GetEmployees();

            foreach (var employee in employees)
            {
                Console.WriteLine("Name: {0}, Salary: {1}", employee.Name, employee.Salay);
            }

            Console.ReadLine();
        }
    }

    class Employee
    {
        public string Name { get; set; }

        public decimal Salay { get; set; }

        public Employee(string name, decimal salay)
        {
            Name = name;
            Salay = salay;
        }
    }

    interface IEmployeeRepository
    {
        List<Employee> GetEmployees();         
    }

    class EmployeeRepository : IEmployeeRepository
    {
        public List<Employee> GetEmployees()
        {
            return new List<Employee>
            {
                new Employee("Patricia", 2000),
                new Employee("Rami", 3000)
            };
        }
    }

    interface IEmployeeBll
    {
        List<Employee> GetEmployees();
    }

    class EmployeeBll : IEmployeeBll
    {
        private readonly IEmployeeRepository _repository;

        public EmployeeBll(IEmployeeRepository repository)
        {
            _repository = repository;
        }

        public List<Employee> GetEmployees()
        {
            return _repository.GetEmployees();
        }
    }



}
