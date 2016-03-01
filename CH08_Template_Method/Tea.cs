using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH08_Template_Method
{
    public class Tea : CaffeineBeverage
    {
        protected override void Brew()
        {
            Console.WriteLine("Steeping the tea");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Adding Lemon");
        }

        protected override void Message()
        {
            Console.WriteLine("\n *** Preparing Tea *** \n");
        }

    }
}
