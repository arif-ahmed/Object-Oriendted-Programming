using CommandDesignPattern.Example_01;

namespace CommandDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Example_01();
            Console.ReadKey();
        }

        static void Example_01()
        {
            // Client
            var light = new Light();
            var lightOn = new LightOnCommand(light);
            var remote = new RemoteControl();
            remote.SetCommand(lightOn);
            remote.PressButton();  // Output: Light is ON
        }
    }
}
