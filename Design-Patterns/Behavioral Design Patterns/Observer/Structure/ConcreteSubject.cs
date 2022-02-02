using System.Collections.Generic;
using System.Linq;

namespace Observer.Structure
{
    public class ConcreteSubject : Subject
    {
        public string SubjectState { get; set; }
        protected IList<Observer> observers = new List<Observer>();
        public override void Attach(Observer observer)
        {
            observers.Add(observer);
        }

        public override void Detach(Observer observer)
        {
            observers.Remove(observer);
        }

        public override void Notify()
        {
            foreach (var observer in observers)
            {
                observer.Update();
            }
        }
    }
}
