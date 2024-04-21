namespace Composite.Core.Observer
{
    public class EventManager<TSender, TEventArgs> where TEventArgs : EventArgs
    {
        private readonly HashSet<Action<TSender, TEventArgs>> _listeners = new();

        public void AddEventListener(Action<TSender, TEventArgs> action)
        {
            _listeners.Add(action);
        }

        public void RemoveEventListener(Action<TSender, TEventArgs> action)
        {
            _listeners.Remove(action);
        }

        public void Invoke(TSender sender, TEventArgs args)
        {
            foreach (var listener in _listeners)
                listener(sender, args);
        }

        public static EventManager<TSender, TEventArgs> operator +
            (EventManager<TSender, TEventArgs> eventListener,
            Action<TSender, TEventArgs> action)
        {
            eventListener.AddEventListener(action);
            return eventListener;
        }

        public static EventManager<TSender, TEventArgs> operator -
            (EventManager<TSender, TEventArgs> eventListener,
            Action<TSender, TEventArgs> action)
        {
            eventListener.RemoveEventListener(action);
            return eventListener;
        }
    }
}
