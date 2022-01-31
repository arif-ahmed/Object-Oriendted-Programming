namespace LSP_Demo.Duck.Violated
{
    using System;

    public class ElectricDuck : IDuck
    {
        private bool _canSwim;
        public void Swim()
        {
            if (!_canSwim)
            {
                return;
            }

            Console.WriteLine("ElectricDuck Swimming");
        }

        public void TurnOn()
        {
            _canSwim = true;
        }
    }
}
