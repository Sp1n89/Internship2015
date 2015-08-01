using System;

namespace DesignPatterns.TemplateMethod
{
    public class Laptop : Device
    {
        protected override void Start()
        {
            Console.WriteLine("Turn on laptop.");
        }

        protected override void End()
        {
            Console.WriteLine("Turn off laptop.");
        }
    }
}