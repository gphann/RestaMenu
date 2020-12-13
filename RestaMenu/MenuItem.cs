using System;
using System.Collections.Generic;
using System.Text;

namespace RestaMenu
{
    public class MenuItem
    {
        public double Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        //appetizer, main course, dessert
        public bool IsNew { get; set; }

        public MenuItem(double price, string description, string category, bool isNew)
        {
            Price = price;
            Description = description;
            Category = category;
            IsNew = isNew;
        }

        public string IsStatusNew()
        {
            if (IsNew == true)
            {
                return ("New Item!");
            }
            else
            {
                return ("Old Item!");
            }
        }

        public override bool Equals(object obj)
        {
            if (this == obj)
            {
                return true;
            }

            if (obj == null)
            {
                return false;
            }

            if (obj.GetType() != this.GetType())
            {
                return false;
            }

            MenuItem other = obj as MenuItem;
            return this.Description == other.Description;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Description);
        }

    }
}
