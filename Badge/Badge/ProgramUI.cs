using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badge
{
    class ProgramUI
    {
        public void Run()
        {
            bool continueToRun = true;

            while (continueToRun)
            {
                Console.WriteLine("Welcome to Komodo Cafe's Virtual Menu!\n\n\n" +
                "Please select an option: \n" +
                "1. See all menu items \n" +
                "2. Add new menu item \n" +
                "3. Delete menu item \n" +
                "0. Exit program");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        DisplayContent();
                        break;
                    case "2":
                        CreateNewContent();
                        break;
                    case "3":
                        RemoveContent();
                        break;
                    case "0":
                        continueToRun = false;
                        break;
                    default:
                        Console.WriteLine("Please make a valid selection.");
                        Console.ReadLine();
                        break;
                }
            }
    }
}
