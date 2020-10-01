using _06_RepositoryPattern_Repository;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace _06_RepositoryPattern_Console
{
    class ProgramUI
    {
        private StreamingContentRepository _contentRepo = new StreamingContentRepository();

        public void Run()
        {
            // before method initiates, load some entries to the list to test method
            SeedContentList();
            // entry point to our Method (starts the application)
            Menu();
        }
        //Menu
        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                //Menu class is private and is only runnable through ProgramUI Method
                //Display our options to the user
                Console.WriteLine("Select a menu opotion:\n" +
                    "1. Create New Content\n" +
                    "2. View all content\n" +
                    "3. View Content by Title\n" +
                    "4. Update Existing Content\n" +
                    "5. Delete Existing Content\n" +
                    "6. Exit");

                //Get the user's input
                string input = Console.ReadLine();

                //Evaluate the user's input and act accordingly
                switch (input)
                {
                    //evaluate based upon the given cases
                    case "1":
                        //Create New Content
                        CreateNewContent();
                        break;
                    case "2":
                        //View all content
                        DisplayAllContent();
                        break;
                    case "3":
                        //view all content by title
                        DisplayContentByTitle();
                        break;
                    case "4":
                        //Update existing Content
                        UpdateExistingContent();
                        break;
                    case "5":
                        //Delete existing content
                        DeleteExistingContent();
                        break;
                    case "6":
                        //Exit\
                        Console.WriteLine("Goodbye!");
                        keepRunning = false; //will stop the console Menu from repeating
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number");
                        break;
                }
                Console.WriteLine("Please press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        //Create new Streaming Content
        private void CreateNewContent()
        {
            Console.Clear();  //Clears the menu off the string
            StreamingContent newContent = new StreamingContent();
            //Title
            Console.WriteLine("Enter the title for the content:");
            newContent.Title = Console.ReadLine();
            //Description
            Console.WriteLine("Enter the description for the content:");
            newContent.Description = Console.ReadLine();
            //Maturity Rating
            Console.WriteLine("Enter the rating for the content (G, PG, PG-13, etc):");
            newContent.MaturityRating = Console.ReadLine();

            //Star Rating
            Console.WriteLine("Enter the star count for the content:");
            string starsAsString = Console.ReadLine();
            newContent.StarRating = double.Parse(starsAsString);

            //IsFamilyFriendly
            Console.WriteLine("Is this content family friendly? (Y/N)");
            string familyFriendlyString = Console.ReadLine().ToLower();

            if (familyFriendlyString == "y")
            {
                newContent.IsFamilyFriendly = true;
            }
            else
            {
                newContent.IsFamilyFriendly = false;
            }

            //GenreType
            Console.WriteLine("Enter the Genre Number:\n" +
                "1. Horror\n" +
                "2. RomCom\n" +
                "3. SciFi\n" +
                "4. Documentary\n" +
                "5. Bromance\n" +
                "6. Drama\n" +
                "7. Action");
            string genreAsString = Console.ReadLine();
            int genreAsInt = int.Parse(genreAsString);  //turns the string into an integer
            newContent.TypeOfGenre = (GenreType)genreAsInt;  //turns the integer untl Genre type (casting)

            _contentRepo.AddContentToList(newContent);
        }
        //View Current Streaming Content that is saved
        private void DisplayAllContent()
            {
            //clear menu from console
            Console.Clear();
            //show everything on our content list
            List<StreamingContent> listOfContent = _contentRepo.GetContentList();

            foreach(StreamingContent content in listOfContent)
            {
                Console.WriteLine($"Title: {content.Title}\n" +
                    $" Description: {content.Description}");
            }
        }

        //View Existing Content by Title
        private void DisplayContentByTitle()
        {
            Console.Clear();
            //prompt user to give me a title
            Console.WriteLine("Enter the title of the content you'd like to see");

            //Get the user's input
            string title = Console.ReadLine();

            //Find the content by that title
            StreamingContent content =_contentRepo.GetContentByTitle(title);

            //Display Streaming Content if it isn't null
            if (content != null)
            {
                Console.WriteLine($"Title: {content.Title}\n" +
                    $" Description: {content.Description}\n" +
                    $"Maturity Rating: {content.MaturityRating}\n" +
                    $"Stars: {content.StarRating}\n" +
                    $"Is Family Friendly: {content.IsFamilyFriendly}\n" +
                    $"Genre: {content.TypeOfGenre}");
            }
            else
            {
                Console.WriteLine("No content by that title");
            }


        }

        //Update Exisintg Content
        private void UpdateExistingContent()
        {
            //Display all content
            DisplayAllContent();
            //Ask for the title of the content to update
            Console.WriteLine("Enter the title of the content you'd like to update:");
            //Get that title
            string oldTitle = Console.ReadLine();

            //We will build a new object
            Console.Clear();  //Clears the menu off the string
            StreamingContent newContent = new StreamingContent();
            //Title
            Console.WriteLine("Enter the title for the content:");
            newContent.Title = Console.ReadLine();
            //Description
            Console.WriteLine("Enter the description for the content:");
            newContent.Description = Console.ReadLine();
            //Maturity Rating
            Console.WriteLine("Enter the rating for the content (G, PG, PG-13, etc):");
            newContent.MaturityRating = Console.ReadLine();

            //Star Rating
            Console.WriteLine("Enter the star count for the content:");
            string starsAsString = Console.ReadLine();
            newContent.StarRating = double.Parse(starsAsString);

            //IsFamilyFriendly
            Console.WriteLine("Is this content family friendly? (Y/N)");
            string familyFriendlyString = Console.ReadLine().ToLower();

            if (familyFriendlyString == "y")
            {
                newContent.IsFamilyFriendly = true;
            }
            else
            {
                newContent.IsFamilyFriendly = false;
            }

            //GenreType
            Console.WriteLine("Enter the Genre Number:\n" +
                "1. Horror\n" +
                "2. RomCom\n" +
                "3. SciFi\n" +
                "4. Documentary\n" +
                "5. Bromance\n" +
                "6. Drama\n" +
                "7. Action");
            string genreAsString = Console.ReadLine();
            int genreAsInt = int.Parse(genreAsString);  //turns the string into an integer
            newContent.TypeOfGenre = (GenreType)genreAsInt;  //turns the integer untl Genre type (casting)

            //verify the update worked
            bool wasUpdated = _contentRepo.UpdateExistingContent(oldTitle, newContent);
            if (wasUpdated)
            {
                Console.WriteLine("Content successfully updated");
            }
            else
            {
                Console.WriteLine("Could not update content");
            }
        }

        //Delete Existing Content
        private void DeleteExistingContent()
        {
            Console.Clear();

            DisplayAllContent(); //provides the list of content of which to select
            // Get the title they want to remove
            Console.WriteLine("\nEnter the title of the content you'd like to remove:");
            string input = Console.ReadLine();
            // Call the delete method
            bool wasDeleted = _contentRepo.RemoveContentFromList(input);

            // If the content was deleted, say so
            if (wasDeleted)
            {
                Console.WriteLine("The content was successfully deleted");
            }
            // Otherwise state it could not be deleted
            else
            {
                Console.WriteLine("The content could not be deleted");
            }

        }
        //See Method
        private void SeedContentList()
        {
            StreamingContent sharknado = new StreamingContent("Sharknado", "Tornados, but with sharks.", "TV-14", 3.3, true, GenreType.Action);
            StreamingContent theRoom  = new StreamingContent("The Room", "Banker's life gets turned upside down.", "R", 3.7, false, GenreType.Drama);
            StreamingContent rubber = new StreamingContent("Rubber", "Car tire comes to life and goes on killing spree", "R", 5.8, false, GenreType.Documentary);

            _contentRepo.AddContentToList(sharknado);
            _contentRepo.AddContentToList(theRoom);
            _contentRepo.AddContentToList(rubber);
        }
    }
}
