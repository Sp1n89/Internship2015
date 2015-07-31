using System;

namespace DesignPatterns.Observer
{
    public class Observer : IObserver
    {
        private readonly Subject _subject;
        private readonly string _name;
        private string _state;

        public Observer(string name, Subject subject)
        {
            _name = name;
            _subject = subject;
        }

        public void Update(string state)
        {
            _state = _subject.State;
            Console.WriteLine("Observer {0}'s new state is {1}", _name, _state);
        }

    }
}