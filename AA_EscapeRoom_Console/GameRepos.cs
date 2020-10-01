using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AA_EscapeRoom_Console
{
    public class GameRepos
    {
        //public string GetPlayerName()
        //{
        //   //was trying to have the GetPlayerName as a sep method to keep each method doing only one thing 
        //}
        public void AddItemToPocket (string item)
        {

        }
        public void Menu()
        {
            Console.WriteLine("Welcome player! What is your name?");
            string playerName = Console.ReadLine();     // make sure to keep using playerName in PlayerClass and PlayerRepo. Add capitol first letter?
            Console.Clear();
            Console.ReadKey();

            Console.WriteLine($"{playerName}, you just woke up in this strange room. You don't know where you are but\n" +
                "what's important is that you find a way to escape. Search the room for things to help\n" +
                $"you break out. Type a number to choose a senario for the path you will take. Good luck {playerName}.\n" +
                "\n");
            
                 while keepRunning = true
                { 
                
                        Console.WriteLine(
                        "1) Open the door\n" +
                        "2) Open the window\n" +
                        "3) Open the box\n" +
                        "4) Scream for help\n" +
                        "5) Inspect the floorboards\n" +
                        "");

                        // Get the user's input
                        string input = Console.ReadLine();
                        // Evaluate the user's input and act accordingly
                        switch (input)
                        {
                            case "1":
                                Console.WriteLine("You jiggle the handle but door is locked.");
                                Console.ReadLine();
                                Menu();
                                break;
                            case "2":
                                Console.WriteLine("You try opening the window but notice it's nailed shut.");
                                break;
                            case "3":
                                Console.WriteLine("The dusty box in the corner has magazines inside.");
                                break;
                            case "4":
                                Console.WriteLine("You scream until your throat hurts but no one responds.");
                                break;
                            case "5":
                                CaseFive();
                                break;
                            default:
                                Console.WriteLine("Please enter a valid number in order to continue the story.");
                                break;
                        }
                  }

                }
            }
        }
        private void CaseFive()
        {
            Console.Clear();
            Console.WriteLine("Scrutinizing the floor, you notice some boards of wood are bent and loose. Prying one up,\n" +
                    "you find a key underneath. The key is now in your inventory.");
            // couldnt we essentially add another switch case here to move the story forward or ultimately end the game?
        }
    }
}

