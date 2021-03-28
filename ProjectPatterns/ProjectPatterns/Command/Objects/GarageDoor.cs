using System;

namespace ProjectPatterns.Command.Objects
{
    public class GarageDoor
    {
        public void Open()
        {
            Console.WriteLine("Drzwi garazu otwarte");
        }

        public void Close()
        {
            Console.WriteLine("Drzwi garazu zakmniete");
        }
    }
}
