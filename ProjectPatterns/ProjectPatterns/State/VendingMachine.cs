using ProjectPatterns.State.Abstract;
using ProjectPatterns.State.States;
using System;

namespace ProjectPatterns.State
{
    public class VendingMachine : IVendingMachine
    {
        public Abstract.State IsCoinState { get; }
        public Abstract.State GumSoldState { get; }
        public Abstract.State NoCoinState { get; }
        public Abstract.State NoGumState { get; }
        public Abstract.State WinState { get; }

        public Abstract.State CurrentState { get; private set; }
        private int gumCount;

        public VendingMachine(int gumCount)
        {
            IsCoinState = new IsCoinState(this);
            GumSoldState = new GumSoldState(this);
            NoCoinState = new NoCoinState(this);
            NoGumState = new NoGumState(this);
            WinState = new WinState(this);

            this.gumCount = gumCount;
            CurrentState = gumCount > 0 ? NoCoinState : NoGumState;
        }

        public void SetState(Abstract.State state)
        {
            CurrentState = state;
        }

        public void InsertCoin()
        {
            CurrentState.InsertCoin();
        }

        public void ReturnCoin()
        {
            CurrentState.ReturnCoin();
        }

        public void TwistKnob()
        {
            CurrentState.TwistKnob();
            CurrentState.Spend();
        }

        public void ReselaseGum()
        {
            Console.WriteLine("Wypada guma...");

            if (gumCount != 0)
            {
                gumCount--;
            }
        }

        public int GetGumCount()
        {
            return gumCount;
        }
    }
}
