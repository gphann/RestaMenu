using System;
using System.Collections.Generic;
using System.Text;

namespace RestaMenu
{
    public class Menu
    {
        public string Name { get; set; }
        public List<MenuItem> FoodItems { get; set; }
        public DateTime LastUpdate { get; }

        public Menu(string Name, List<MenuItem> foodItem, DateTime LastUpdate)
        {
            this.Name = Name;
            FoodItems = foodItem;
            //FoodItems = new List<MenuItem>();
            this.LastUpdate = LastUpdate;
        }

        public List<MenuItem> AddFoodItem(MenuItem foodItem)
        {
            FoodItems.Add(foodItem);
            return FoodItems;
        }

        public List<MenuItem> RemoveFoodItem(MenuItem foodItem)
        {
            for (int i = 0; i < FoodItems.Count; i++)
            {
              if (FoodItems[i].Equals(foodItem))
                {
                    FoodItems.Remove(foodItem);
                }
            }
            return FoodItems;
        }

        public string MenuLastUpdated(DateTime LastUpdate)
        {
            return ("Menu last updated on " + LastUpdate);
        }

        public void PrintMenu()
        {
            for (int i = 0; i < FoodItems.Count; i++)
            {
                Console.WriteLine(FoodItems[i].Price + " " + FoodItems[i].Description);
            }
        }

        public void PrintFoodItem(MenuItem foodItem)
        {
            Console.WriteLine(foodItem.Price + " " + foodItem.Description);
        }
    }
}
