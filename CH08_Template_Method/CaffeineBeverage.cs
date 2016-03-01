using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH08_Template_Method
{
    public abstract class CaffeineBeverage
    {
        public void PrepareRecipe()
        {
            Message(); //Hooked Method
            BoilWater();
            Brew();
            PourInCup();
            AddCondiments();
        }

        protected abstract void Brew();

        protected abstract void AddCondiments();

        protected void BoilWater()
        {
            Console.WriteLine("Boiling Water");
        }

        protected void PourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }

        protected virtual void Message()
        { Console.WriteLine("\n"); }

    }
}
