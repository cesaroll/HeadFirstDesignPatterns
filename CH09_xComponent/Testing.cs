

using System.Runtime.Remoting.Messaging;
using CH09_xComponent.Composite;

namespace CH09_xComponent
{
    class Testing
    {
        static void Main(string[] args)
        {
            MenuComponent pancakeHouseMenu = new Menu("PANCAKE HOUSE MENU", "Breakfast");
            MenuComponent dinnerMenu = new Menu("DINNER MENU", "Lunch");
            MenuComponent cafeMenu = new Menu("CAFE MENU", "Dinner");
            MenuComponent dessertMenu = new Menu("DESERT MENU", "Desert of course");

            MenuComponent allMenus = new Menu("ALL MENUS", "All menus combined");

            allMenus.Add(pancakeHouseMenu);
            allMenus.Add(dinnerMenu);
            allMenus.Add(cafeMenu);

            pancakeHouseMenu.Add(new MenuItem("K&B's Pancake Breakfast", "Pancakes with scrambled eggs, sausage", false, 2.99));
            pancakeHouseMenu.Add(new MenuItem("Regular Pancake Breakfast", "Pancakes made with blueberries", true, 3.49));

            dinnerMenu.Add(new MenuItem("Vegetarian BLT", "(Fakin') Bacon with Lettuce & tomato on whole wheat", true, 2.99));
            dinnerMenu.Add(new MenuItem("BLT", "Bacon with Lettuce & tomato on whole wheat", false, 2.99));

            dinnerMenu.Add(dessertMenu);

            dessertMenu.Add(new MenuItem("Apple Pie", "Apple pie with flaky crsut, topped with vanilla ice cream", true, 1.59));

            cafeMenu.Add(new MenuItem("Veggie Burger and Air Fries", "Veggie burguer on a whole wheat bun, lettuce, tomato and fries", true, 3.99));
            cafeMenu.Add(new MenuItem("Soup of the Day", "A coup of the soup of the day with a side salad", false, 3.69));

            Waitress waitress = new Waitress(allMenus);
            waitress.PrintMenu();
            waitress.PrintVegetarianMenu();

        }
    }
}
