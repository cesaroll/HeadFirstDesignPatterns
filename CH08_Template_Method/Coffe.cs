using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH08_Template_Method
{
    public class Coffe : CaffeineBeverage
    {
        protected override void Brew()
        {
            Console.WriteLine("Dipping Coffe through filter");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Adding Sugar and Milk");
        }

        protected override void Message()
        {
            Console.WriteLine("\n *** Preparing Coffe *** \n");
        }
    }
}
