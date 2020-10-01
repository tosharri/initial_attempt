using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RickAndMortyGame
{
    public class ProgramUI
    {

        Dictionary<string, Room> Rooms = new Dictionary<string, Room> 
        {
            {"garage", garage },
            {"house", house },
            {"driveway", driveway },
        };

        public enum Item { plumbus, meeseeks, portalgun };

        public List<Item> inventory = new List<Item>();


        public static Room garage = new Room(
            "\n\n\n\n\nYou're in the garage with all your junk and crap.\n\n" +
            "Obvious exits are DRIVEWAY and HOUSE\n",
            new List { "driveway", "house" });
        public static Room driveway = new Room(
            "\n\n\n\n\nYou're in the driveway. The car is gone but \n" +
            "the oil stain is still there.\n\n" +
            "Obvious exits are GARAGE and YARD\n",
            new List { "garage" });
        public static Room house = new Room(
            "\n\n\n\nYou're in the house now.  Its drab and smells like " +
            "lemon pine-sol with a hint of stale fart.\n\n" +
            "Obvious exits are GARAGE and KITCHEN\n",
             new List { "garage" });
        public void Run()
        {
            Room currentRoom = garage;
            Console.Clear();
            Console.WriteLine("You accidentally killed Morty!\n" +
                "In order to construct a passable facsimile, you must collect\n" +
                "more Mortys from other dimensions to assemble from them|n" +
                "Morty's genetic structure and connectome.");

            bool alive = true;
            while (alive)
            {          
                Console.Clear();

                Console.WriteLine(currentRoom.Splash);

                string command = Console.ReadLine().ToLower();


                if (command.StartsWith("go ") || command.StartsWith("exit"))
                {
                    foreach (string exit in currentRoom.Exits)
                    {
                        if (command.Contains(exit) &&
                            Rooms.ContainsKey(exit))
                        {
                            currentRoom = Rooms[exit];
                            foundExit = true;
                            break;
                        }
                    }
                    if(!foundExit)
                    { 
                        Console.WriteLine("Uhh.....go where?");
                    }
                }
                else if (command.StartsWith("get ") || command.StartsWith("take ") || command.StartsWith("grab "))
                {
                    Console.WriteLine("I don't know what you're talking about.");
                }
                else if (command.StartsWith("use ") || command.StartsWith("activate"))
                {
                    Console.WriteLine("I doubt you know how.");
                }
                else
                {
                    Console.WriteLine("*BUUUUUURP What?");
                }
            }

        }
    }
}
