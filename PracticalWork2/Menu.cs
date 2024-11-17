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

    }
}
