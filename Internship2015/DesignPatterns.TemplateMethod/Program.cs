using System;

namespace DesignPatterns.TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Device mobile = new MobilePhone();
            Device laptop = new Laptop();

            mobile.SendEmail("client_1@mail.com", "client_2@mail.com", "Hello", "How are you?");
            laptop.SendEmail("client_2@mail.com", "client_1@mail.com", "Good", "Good. Thank you!");

            Console.ReadLine();
        }
    }
}
