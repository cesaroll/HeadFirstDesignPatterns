﻿using System;
using CH11_Proxy_Remote.Machines;

namespace CH11_Proxy_Remote.Interfaces.Implementations
{
    public class SoldState : State
    {
        private GumballMachine _gbMachine;

        public SoldState(GumballMachine gbMachine)
        {
            _gbMachine = gbMachine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Please wait, we are already giving you a guball");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Sorry, you already turned the crank");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Turnning twice doesn't give you another gumball!");
        }

        public void Dispense()
        {
            _gbMachine.ReleaseBall();

            if (_gbMachine.Count > 0)
                _gbMachine.State = _gbMachine.NoQuarterState;
            else
            {
                Console.WriteLine("Oops, out of gumballs");
                _gbMachine.State = _gbMachine.SoldOutState;
            }

        }

        public override string ToString()
        {
            return "Gumball has been sold";
        }

    }
}