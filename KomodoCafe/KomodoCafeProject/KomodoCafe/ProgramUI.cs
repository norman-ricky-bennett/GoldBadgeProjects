using KomodoRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KomodoCafe
{
    class ProgramUI
    {
        private readonly MenuItem_Repo _repo = new MenuItem_Repo();
        public void Run()
        {
            SeedData();

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
                        // RemoveContent();
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




        private void DisplayContent()
        {
            Console.Clear();

            List<MenuItem> listOfItems = _repo.GetContents();

            foreach (MenuItem item in listOfItems)
            {
                Console.WriteLine($"Meal Number: {item.MealNumber}\n" +
                    $"Dish: {item.MealName}\n" +
                    $"Description: {item.MealDescription}\n" +
                    $"Ingredients: {item.MealIngredients}\n" +
                    $"Price: {item.MealPrice}");

            }
        }

        private void CreateNewContent()
        {
            Console.Clear();

            MenuItem item = new MenuItem();

            Console.WriteLine("Please enter the meal number: ");
            item.MealNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the meal name: ");
            item.MealName = Console.ReadLine();

            Console.WriteLine("Please enter the meal description: ");
            item.MealDescription = Console.ReadLine();

            Console.WriteLine("Please enter the meal ingredients: ");
            item.MealIngredients = Console.ReadLine();

            Console.WriteLine("Please enter the meal price: ");
            item.MealPrice = Convert.ToDouble(Console.ReadLine());

            _repo.AddItemToDirectory(item);
        }

        //private void RemoveContent()
        //{
        //    DisplayContent();
        //    Console.WriteLine("Which meal would you like to delete?");
        //    int mealNum = int.Parse(Console.ReadLine());

        //    bool wasDeleted = _repo.RemoveContent(mealNum);

        //    if (wasDeleted)
        //    {
        //        Console.WriteLine("Menu Item Deleted");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Could not be deleted");
        //    }
        //}

        private void SeedData()
        {
            MenuItem itemOne = new MenuItem(1, "Spaghetti", "Pasta with sauce", "Pasta, sauce, cheese", 9.99);
            _repo.AddItemToDirectory(itemOne);
        }

    }
}
