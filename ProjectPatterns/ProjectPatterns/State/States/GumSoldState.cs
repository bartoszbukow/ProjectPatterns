using System;

namespace ProjectPatterns.State.States
{
    public class GumSoldState : Abstract.State
    {
        public GumSoldState(VendingMachine vendingMachine) : base(vendingMachine)
        {

        }

        public override void InsertCoin()
        {
            Console.WriteLine("Proszę czekac na gumę");
        }

        public override void ReturnCoin()
        {
            Console.WriteLine("Niestety, nie można zwrócić monety po przekręceniu gałki");
        }

        public override void Spend()
        {
            _vendingMachine.ReselaseGum();

            if(_vendingMachine.GetGumCount() > 0)
            {
                _vendingMachine.SetState(_vendingMachine.NoCoinState);
            }
            else
            {
                Console.WriteLine("Ups, koniec gum!");
                _vendingMachine.SetState(_vendingMachine.NoGumState);
            }
        }

        public override void TwistKnob()
        {
            Console.WriteLine("Nie dostaniesz gumy tylko dlatego, że przekręciłeś drugi raz!");
        }
    }
}
