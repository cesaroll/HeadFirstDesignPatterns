using System;
using CH11_Proxy_Remote.Machines;

namespace CH11_Proxy_Remote.Interfaces.Implementations
{
    public class SoldOutState : State
    {
        private GumballMachine _gbMachine;

        public SoldOutState(GumballMachine gbMachine)
        {
            _gbMachine = gbMachine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Sorry, Sold out!");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("No quarter inserted");
        }

        public void TurnCrank()
        {
            Console.WriteLine("No quarter inserted and sold out!");
        }

        public void Dispense()
        {
            Console.WriteLine("NOthng to dispense");
        }

        public override string ToString()
        {
            return "Machine is Sold Out";
        }
    }
}