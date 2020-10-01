using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RickAndMortyGame
{
    public class Room
    {
        public string Splash { get; }
        public List<string> Exits { get; }

        public List<ProgramUI.Item> Items { get; }

        public Room(string splash, List<string> exits, List<ProgramUI.Item> items)
        {
            Splash = splash;
            Exits = exits;
            Items = items;
        }
        public List<ProgramUI.Item> Items { get; }

        public void RemoveItem(ProgramUI.Item item)
        {
            if (Items.Contains(item))

            {
                Items.Remove(item);
            }
        }
    }
}
