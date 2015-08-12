using System;

namespace DesignPatterns.Observer.Example2
{
    public class ChannelAdmin : ISubscriber
    {
        public string Name { get; set; }

        public ChannelAdmin(string name)
        {
            Name = name;
        }

        public void Update(string video)
        {
            Console.WriteLine("{0} is verifying video {1}", Name, video);
        }
    }
}