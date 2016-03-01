using System;
using System.Collections;
using CH09_Iterator.Items;
using CH09_Iterator.Menu;
using CH09_Iterator.Menus;

namespace CH09_Iterator
{
    public class Waitress
    {
        private IMenu[] Menus { get; set; }

        public Waitress(params IMenu[] menus)
        {
            Menus = menus;
        }

        public void PrintMenu()
        {
            IEnumerator menusEnum = Menus.GetEnumerator();

            Console.WriteLine("\n");
            while (menusEnum.MoveNext())
            {
                PrintMenu(((IMenu)menusEnum.Current).CreateEnumerator());
            }

            Console.WriteLine("\n");
        }

        private void PrintMenu(IEnumerator enumerator)
        {
            while (enumerator.MoveNext())
            {
                var menuItem = (MenuItem)enumerator.Current;
                if(menuItem != null)
                    Console.WriteLine(menuItem);
            }
        }
    }
}