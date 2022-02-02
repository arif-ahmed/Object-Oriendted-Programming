using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.CriminalSurveillanceSystem
{
    public class Inspector : IObserver<Message>
    {
        private IDisposable unsubscriber;
        private string instName;

        public Inspector(string name)
        {
            this.instName = name;
        }

        public string Name
        {
            get
            {
                return this.instName;
            }
        }

        public virtual void Subscribe(IObservable<Message> provider)
        {
            if (provider != null)
                unsubscriber = provider.Subscribe(this);
        }

        public virtual void OnCompleted()
        {
            Console.WriteLine("The headquarters has completed transmitting data to {0}.", this.Name);
            this.Unsubscribe();
        }

        public virtual void OnError(Exception e)
        {
            Console.WriteLine("{0}: Cannot get message from headquarters.", this.Name);
        }

        public virtual void OnNext(Message value)
        {
            Console.WriteLine("{1}: Message I got from headquarters: {0}", value.Text, this.Name);
        }

        public virtual void Unsubscribe()
        {
            unsubscriber.Dispose();
        }
    }
}
