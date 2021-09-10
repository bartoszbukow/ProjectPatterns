using System;

namespace ProjectPatterns.State.States
{
    public class NoGumState : Abstract.State
    {
        public NoGumState(VendingMachine vendingMachine) : base(vendingMachine)
        {

        }

        public override void InsertCoin()
        {
            Console.WriteLine("Nie można wrzucić monety, automat jest pusty!");
        }

        public override void ReturnCoin()
        {
            Console.WriteLine("Nie można zwrócić monety, żadna nie została zwrócona");
        }

        public override void Spend()
        {
            Console.WriteLine("Nie widano gumy");
        }

        public override void TwistKnob()
        {
            Console.WriteLine("Obróciłeś gałke, ale automat jest pusty");
        }
    }
}
