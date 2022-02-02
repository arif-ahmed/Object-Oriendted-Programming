namespace Observer.Structure
{
    public abstract class Subject
    {
       public abstract void Attach(Observer observer);
       public abstract void Detach(Observer observer);
       public abstract void Notify();
    }
}
