using System;

namespace ProjectPatterns.Command.Objects
{
    public class StereoSystem
    {
        public void TurnOn()
        {
            Console.WriteLine("Wieza stereo wlaczona");
        }

        public void SetCD()
        {
            Console.WriteLine("Ustawiono CD");
        }

        public void SetVolume(int value)
        {
            Console.WriteLine($"Ustawiono glosnosc na {value}");
        }

        public void TurnOff()
        {
            Console.WriteLine("Wieza stereo wylaczona");
        }
    }
}
