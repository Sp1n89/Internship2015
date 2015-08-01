using System;

namespace DesignPatterns.TemplateMethod
{
    public class MobilePhone : Device
    {
        protected override void Start()
        {
            Console.WriteLine("Unlock mobile phone.");
        }

        protected override void End()
        {
            Console.WriteLine("Lock mobile phone.");
        }
    }
}