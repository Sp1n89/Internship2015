using System.Collections.Generic;

namespace DesignPatterns.Observer
{
    public class Subject
    {
        private readonly IList<IObserver> _observers;

        private string _state;
        public string State
        {
            get { return _state; }
            set
            {
                _state = value;
                Notify();
            }
        }

        public Subject()
        {
            _observers = new List<IObserver>();
        }

        public void Attach(IObserver observer)
        {
            if (!_observers.Contains(observer))
            {
                _observers.Add(observer);
            }
        }

        public void Detach(IObserver observer)
        {
            if (_observers.Contains(observer))
            {
                _observers.Remove(observer);
            }
        }

        private void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update(State);
            }
        }
    }
}