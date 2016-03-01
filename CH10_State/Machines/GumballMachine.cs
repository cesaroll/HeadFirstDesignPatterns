using System;
using System.Threading;
using CH11_Proxy_Remote.Interfaces;
using CH11_Proxy_Remote.Interfaces.Implementations;

namespace CH11_Proxy_Remote.Machines
{
    public class GumballMachine
    {
        public State SoldOutState { get; set; }
        public State NoQuarterState { get; set; }
        public State HasQuarterState { get; set; }
        public State SoldState { get; set; }
        public State WinnerState { get; set; }

        public State State { get; set; }

        public int Count { get; set; }

        public GumballMachine(int numGumballs)
        {
            SoldOutState = new SoldOutState(this);
            NoQuarterState = new NoQuarterState(this);
            HasQuarterState = new HasQuarterState(this);
            SoldState = new SoldState(this);
            WinnerState = new WinnerState(this);

            this.Count = numGumballs;

            this.State = numGumballs > 0 ? NoQuarterState : SoldOutState;
        }

        public void InsertQuarter()
        {
            this.State.InsertQuarter();
        }

        public void EjectQuarter()
        {
            this.State.EjectQuarter();
        }

        public void TurnCrank()
        {
            this.State.TurnCrank();
            this.State.Dispense();
        }

        public void ReleaseBall()
        {
            Console.WriteLine("A gumball comes rolling out the slot...");
            this.Count = this.Count > 0 ? this.Count - 1 : 0;
        }

        public override string ToString()
        {
            return String.Format("\nMighty Gumball, inc.\nC# Enabled Standing Gumball Model #2014\nInventory: {0} gumballs\n{1}\n",this.Count, this.State.ToString());
        }
    }
}