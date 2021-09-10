using System;

namespace ProjectPatterns.State.States
{
    public class NoCoinState : Abstract.State
    {
        public NoCoinState(VendingMachine vendingMachine) : base(vendingMachine)
        {

        }

        public override void InsertCoin()
        {
            Console.WriteLine("Moneta przyjęta");
            _vendingMachine.SetState(_vendingMachine.IsCoinState);
        }

        public override void ReturnCoin()
        {
            Console.WriteLine("Nie włożyłeś monety");
        }

        public override void Spend()
        {
            Console.WriteLine("Zanim przekręcisz gałkę, wrzuć monetę");
        }

        public override void TwistKnob()
        {
            Console.WriteLine("Najpierw zapłać");
        }
    }
}
