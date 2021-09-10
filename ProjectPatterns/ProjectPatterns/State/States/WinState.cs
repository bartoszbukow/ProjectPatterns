using System;

namespace ProjectPatterns.State.States
{
    public class WinState : Abstract.State
    {
        public WinState(VendingMachine vendingMachine) : base(vendingMachine)
        {

        }

        public override void InsertCoin()
        {
            Console.WriteLine("Nie można wrzucić monety");
        }

        public override void ReturnCoin()
        {
            Console.WriteLine("Nie można zwrócić monety");
        }

        public override void Spend()
        {
            Console.WriteLine("WYGRAŁES! Dostajesz druga gume");
            _vendingMachine.ReselaseGum();
            
            if(_vendingMachine.GetGumCount() == 0)
            {
                _vendingMachine.SetState(_vendingMachine.NoGumState);
            }
            else
            {
                _vendingMachine.ReselaseGum();

                if (_vendingMachine.GetGumCount() > 0)
                {
                    _vendingMachine.SetState(_vendingMachine.NoCoinState);
                }
                else
                {
                    Console.WriteLine("Ups, koniec gum!");
                    _vendingMachine.SetState(_vendingMachine.NoGumState);
                }
            }
        }

        public override void TwistKnob()
        {
            Console.WriteLine("Nie można przekręcić gałki");
        }
    }
}
