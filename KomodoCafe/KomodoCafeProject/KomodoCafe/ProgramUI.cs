using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KomodoCafe
{
    class ProgramUI
    {
        public void Run()
        {
            bool continueToRun = true;

            while (continueToRun = true)
            {
                Console.WriteLine("Welcome to Komodo Cafe's Virtual Menu!\n" +
                "Please select an option: \n" +
                "1. See all menu items \n" +
                "2. Add new menu item \n" +
                "3. Delete menu item \n" +
                "0. Exit program");
            }

            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    ShowAllContent();
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
        public void ShowAllContent()
        {
            Console.Clear();

            List<MenuItem> listOfMenuItems = _repo.GetContent();

            foreach (MenuItem content in listOfMenuItems)
            {
                DisplayContent(content);
            }
            Console.ReadKey();
        }

        private void DisplayContent(MenuItem item)
        {
            Console.WriteLine($"Meal Number: {item.MealNumber}\n" +
                $"Dish: {item.MealName}\n" +
                $"Description: {item.MealDescription}\n" +
                $"Ingredients: {item.MealIngredients}\n" +
                $"Price: {item.MealPrice}");
        }

        private void CreateNewContent()
        {
            Console.Clear();

            MenuItem item = new MenuItem();

            Console.WriteLine("Please enter the meal number: ");
            item.MealNumber = Console.ReadLine();

            Console.WriteLine("Please enter the meal name: ");
            item.MealName = Console.ReadLine();

            Console.WriteLine("Please enter the meal description: ");
            item.MealDescription = Console.ReadLine();

            Console.WriteLine("Please enter the meal ingredients: ");
            item.MealIngredients = Console.ReadLine();

            Console.WriteLine("Please enter the meal price: ");
            item.MealPrice = Console.ReadLine();
        
        }

        private void RemoveContent()
        {

        }

    }
}
   