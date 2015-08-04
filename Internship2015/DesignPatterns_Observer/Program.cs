using System;

namespace DesignPatterns.Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var subject = new Subject();
            var ob1 = new Observer("Observer_1", subject);
            var ob2 = new Observer("Observer_2", subject);

            subject.Attach(ob1);
            subject.Attach(ob2);

            subject.State = "UPDATED!!!";
            
            Console.ReadLine();
        }
    }
}
