using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badge
{
    class ProgramUI
    {
        public Dictionary<int, List<string>> _dict = new Dictionary<int, List<string>>();
        public void Run()
        {
            bool continueToRun = true;

            while (continueToRun)
            {
                Console.WriteLine("Hello Security Admin. What would you like to do?\n\n\n" +
                "Please select an option: \n" +
                "1. Add a badge \n" +
                "2. Edit a badge \n" +
                "3. List all badges \n" +
                "0. Exit program");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        CreateBadge();
                        break;
                    case "2":
                        UpdateBadge();
                        break;
                    case "3":
                        ListBadges();
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

        public void CreateBadge()
        {

        }

        public void UpdateBadge()
        {

        }

        public void ListBadges()
        {

        }

        public void SeedData()
        {
            
        }
    }
}
