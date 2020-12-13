using System;
using System.Collections.Generic;
using System.Text;

namespace RestaMenu
{
    public class Restaurant
    {
        static void Main(string[] args)
        {
            MenuItem potstickers = new MenuItem(8, "Panfried dumpling", "Appetizer", true);
            MenuItem pho = new MenuItem(10, "Vietnamese noodle soup", "Main course", true);
            MenuItem pie = new MenuItem(5, "A sweet dessert", "Dessert", true);

            DateTime today = DateTime.Now;
            List<MenuItem> startMenu = new List<MenuItem>();

            Menu ourMenu = new Menu("Menu Menu", startMenu, today);

            ourMenu.AddFoodItem(potstickers);
            ourMenu.AddFoodItem(pho);
            ourMenu.AddFoodItem(pie);


            ourMenu.PrintMenu();

            ourMenu.PrintFoodItem(potstickers);

            ourMenu.RemoveFoodItem(pho);

            ourMenu.PrintMenu();

        }
    }
}
