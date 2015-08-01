using System;

namespace DesignPatterns.TemplateMethod
{
    public abstract class Device : ICanSendEmail
    {
        private static void Send(string from, string to, string subject, string text)
        {
            Console.WriteLine("From: {0}", from);
            Console.WriteLine("To: {0}", to);
            Console.WriteLine("Subject: {0}", subject);
            Console.WriteLine("Body: {0}", text);
        }

        public void SendEmail(string from, string to, string subject, string text)
        {
            Start();
            Send(from, to, subject, text);
            End();
            Console.WriteLine("\n\n");
        }

        protected abstract void Start();

        protected abstract void End();
    }
}