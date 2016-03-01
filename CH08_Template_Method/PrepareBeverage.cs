using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH08_Template_Method
{
    class PrepareBeverage
    {
        static void Main(string[] args)
        {
            CaffeineBeverage tea = new Tea();

            CaffeineBeverage coffe = new Coffe();

            tea.PrepareRecipe();

            coffe.PrepareRecipe();


        }
    }
}
