namespace Mediator.Example_01
{
    /// <summary>
    /// The 'Colleague' abstract class
    /// </summary>
    public abstract class Colleague
    {
        protected Mediator mediator;
        // Constructor
        public Colleague(Mediator mediator)
        {
            this.mediator = mediator;
        }
    }
}
