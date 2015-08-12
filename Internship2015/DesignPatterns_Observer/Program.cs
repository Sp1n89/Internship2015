using System;
using DesignPatterns.Observer.Example2;

namespace DesignPatterns.Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            //var subject = new Subject();
            //var ob1 = new Observer("Observer_1", subject);
            //var ob2 = new Observer("Observer_2", subject);

            //subject.Attach(ob1);
            //subject.Attach(ob2);

            //subject.State = "UPDATED!!!";

            var youtubeChannel = new YouTubeChannel();
            var client = new Client("Rami");
            var admin = new ChannelAdmin("John");

            youtubeChannel.Subscribe(client);
            youtubeChannel.Subscribe(admin);

            youtubeChannel.LastVideo = "C# Design Patterns";

            Console.ReadLine();
        }
    }
}
