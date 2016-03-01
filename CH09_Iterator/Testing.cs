using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CH09_Iterator.Items;
using CH09_Iterator.Menus;

namespace CH09_Iterator
{
    class Testing
    {
        static void Main(string[] args)
        {
            (new Waitress(new PancakeHouseMenu(), new DinerMenu(), new CafeMenu())).PrintMenu();

        }
    }
}
