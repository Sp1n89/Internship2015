using System;

namespace DesignPatterns.Observer.Example2
{
    public class Client : ISubscriber
    {
        public string Name { get; set; }

        public Client(string name)
        {
            Name = name;
        }

        public void Update(string video)
        {
            Console.WriteLine("{0} is watching video {1}", Name, video);
        }
    }
}