
namespace ProjectPatterns.State.Abstract
{
    public abstract class State
    {
        protected readonly VendingMachine _vendingMachine;

        public State(VendingMachine vendingMachine)
        {
            _vendingMachine = vendingMachine;
        }

        public abstract void InsertCoin();
        public abstract void ReturnCoin();
        public abstract void TwistKnob();
        public abstract void Spend();
    }
}
