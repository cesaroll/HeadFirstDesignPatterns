using System;
namespace CH11_Proxy_Remote.Interfaces
{    
    public interface State
    {
        void InsertQuarter();
        void EjectQuarter();
        void TurnCrank();
        void Dispense();

    }
}