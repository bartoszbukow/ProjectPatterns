using ProjectPatterns.Adapter.Abstract;
using System;
namespace ProjectPatterns.Adapter
{
    public class WildTurkey : ITurkey
    {
        public void Fly()
        {
            Console.WriteLine("O rany! Latam!... ale tylko na krotkich dystansach");
        }

        public void Gobble()
        {
            Console.WriteLine("Gulgulgul!");
        }
    }
}
