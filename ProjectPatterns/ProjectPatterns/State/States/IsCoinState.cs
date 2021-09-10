using System;

namespace ProjectPatterns.State.States
{
    public class IsCoinState : Abstract.State
    {
        private readonly Random _randomWin = new Random();

        public IsCoinState(VendingMachine vendingMachine) : base(vendingMachine)
        {

        }

        public override void InsertCoin()
        {
            Console.WriteLine("Nie możesz włożyć więcej niż jednej monety");
        }

        public override void ReturnCoin()
        {
            Console.WriteLine("Moneta zwrócona");
            _vendingMachine.SetState(_vendingMachine.NoCoinState);
        }

        public override void Spend()
        {
            Console.WriteLine("Nie wydano gumy");
        }

        public override void TwistKnob()
        {
            Console.WriteLine("Obróciłeś gałkę");

            var win = _randomWin.Next(1, 10);

            if (win == 1)
            {
                _vendingMachine.SetState(_vendingMachine.WinState);
            }
            else
            {
                _vendingMachine.SetState(_vendingMachine.GumSoldState);
            }
        }
    }
}
