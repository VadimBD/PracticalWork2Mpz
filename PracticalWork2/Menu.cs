using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalWork2
{
    internal class Menu
    {
        public string Name { get; set; }
        List<MenuItem> Items { get; set; } = [];
        public Menu(string name) 
        {
            Name = name;
        }
        public Menu(string name,List<MenuItem> menuItems)
        {
            Name = name;
            Items = menuItems;
        }

        public void AddMenuItem(MenuItem item) {

            if (Items.Contains(item))
                throw new Exception("The item is already contained in the collection");
            else 
                Items.Add(item);
        }
        public void RemoveMenuItem(MenuItem item)
        {
            if (Items.Contains(item))
                Items.Remove(item);
            else
                throw new Exception("The element is not contained in the collection");
        }
        public void ViewMenu()
        {
            foreach (MenuItem item in Items)
            {
                Console.WriteLine($"{item.Name} {item.Price} {item.Description}");
                Console.WriteLine("Ingredients:");
                var len = item.Ingredients.Count - 1;
                for (int i = 0; i < len; i++)
                {
                    if(i!= len)
                    {
                        Console.WriteLine($"{item.Ingredients[i]},");
                    }
                    else
                    {
                        Console.WriteLine($"{item.Ingredients[i]}");
                    }
                }
            }
        }
    }
}
