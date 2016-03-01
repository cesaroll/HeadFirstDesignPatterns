using System;
using System.Collections;
using CH09_xComponent.Composite;

namespace CH09_xComponent
{
    public class Waitress
    {
        private MenuComponent AllMenus { get; set; }

        public Waitress(MenuComponent allMenus)
        {
            AllMenus = allMenus;
        }

        public void PrintMenu()
        {
            AllMenus.Print();
        }


        public void PrintVegetarianMenu()
        {
            IEnumerator enumerator = AllMenus.CreatEnumerator();

            Console.WriteLine("\n\nVEGETARIAN MENU\n----");

            
            while(enumerator.MoveNext())
            {
                MenuComponent menuComponent = (MenuComponent) enumerator.Current;

                try
                {
                    if(menuComponent.IsVegetarian)
                        menuComponent.Print();
                }
                catch (NotSupportedException) { }

            }

        }

    }
}