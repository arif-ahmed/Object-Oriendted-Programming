using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.CriminalSurveillanceSystem
{
    public class Headquarter : IObservable<Message>
    {
        public Headquarter()
        {
            observers = new List<IObserver<Message>>();
        }

        private List<IObserver<Message>> observers;

        public IDisposable Subscribe(IObserver<Message> observer)
        {
            if(!observers.Contains(observer))
            {
                observers.Add(observer);
            }

            return new Unsubscriber(observers, observer);
        }

        private class Unsubscriber : IDisposable
        {
            private List<IObserver<Message>> _observers;
            private IObserver<Message> _observer;

            public Unsubscriber(List<IObserver<Message>> observers, IObserver<Message> observer)
            {
                this._observers = observers;
                this._observer = observer;
            }

            public void Dispose()
            {
                if (_observer != null && _observers.Contains(_observer))
                    _observers.Remove(_observer);
            }
        }

        public void SendMessage(Nullable<Message> loc)
        {
            foreach (var observer in observers)
            {
                if (!loc.HasValue)
                    observer.OnError(new MessageUnknownException());
                else
                    observer.OnNext(loc.Value);
            }
        }

        public void EndTransmission()
        {
            foreach (var observer in observers.ToArray())
                if (observers.Contains(observer))
                    observer.OnCompleted();

            observers.Clear();
        }
    }
}
