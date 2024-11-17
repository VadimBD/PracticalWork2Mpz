using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalWork2
{
    internal class MenuItem
    {
        public int MenuItemId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<string> Ingredients { get; set; }
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }

        public MenuItem(int menuItemId, string name, string description, decimal price, bool isAvailable)
        {
            MenuItemId = menuItemId;
            Name = name;
            Description = description;
            Ingredients = new List<string>();
            Price = price;
            IsAvailable = isAvailable;
        }
    }
}
