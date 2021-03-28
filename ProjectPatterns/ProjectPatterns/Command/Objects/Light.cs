using System;

namespace ProjectPatterns.Command.Objects
{
    public class Light
    {
        public void TurnOn()
        {
            Console.WriteLine("Swiatlo wlaczone");
        }

        public void TurnOff()
        {
            Console.WriteLine("Swiatlo wylaczone");
        }
    }
}
