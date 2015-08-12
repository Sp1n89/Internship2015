using System.Collections.Generic;

namespace DesignPatterns.Observer.Example2
{
    public class YouTubeChannel
    {
        private List<ISubscriber> _subscribers;

        public YouTubeChannel()
        {
            _subscribers = new List<ISubscriber>();
        }

        private string _lastVideo;
        public string LastVideo
        {
            get { return _lastVideo; }
            set
            {
                _lastVideo = value;
                Notify();
            }
        }

        public void Subscribe(ISubscriber subscriber)
        {
            if (!_subscribers.Contains(subscriber))
            {
                _subscribers.Add(subscriber);
            }
        }

        public void UnSubscribe(ISubscriber subscriber)
        {
            if (_subscribers.Contains(subscriber))
            {
                _subscribers.Remove(subscriber);
            }
        }

        private void Notify()
        {
            foreach (var subscriber in _subscribers)
            {
                subscriber.Update(LastVideo);
            }
        }

    }
}