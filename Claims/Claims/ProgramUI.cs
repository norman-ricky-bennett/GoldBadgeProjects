using ClaimsRepo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Claims
{
    class ProgramUI
    {
        public readonly ClaimsEntry_Repo _repo = new ClaimsEntry_Repo();


        

        public bool continueToRun = true;
        public void Run()
        {
            SeedData();

            bool continueToRun = true;


            while (continueToRun)
            {
                Console.Clear();
                Console.WriteLine("Welcome to Komodo Virtual Claims.\n" +
                    "Please select an option from the menu: \n" +
                    "1. View All Claims\n" +
                    "2. View Next Claim\n" +
                    "3. Enter a New Claim");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        ViewAllClaims();
                        break;
                    case "2":
                        ViewNextClaim();
                        break;
                    case "3":
                        CreateNewClaim();
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

        public void ViewAllClaims()
        {
            Console.Clear();

            Queue<ClaimEntry> allClaims = _repo.GetContents();

            Console.WriteLine("ClaimID\t Type\t Description\t Amount\t DateOFAccident\t DateOfClaim\t IsValid\t");
            foreach (ClaimEntry entry in allClaims)
            {
                Console.WriteLine($"{entry.ClaimID}\t" +
                    $"{entry.ClaimType}\t" +
                    $"{entry.ClaimDescription}\t" +
                    $"{entry.ClaimAmount}\t" +
                    $"{entry.DateOfIncident}\t" +
                    $"{entry.DateOfClaim}\t" +
                    $"{entry.IsValid}");
            }
            Console.ReadKey();
        }

        public void ViewNextClaim()
        {
            Console.Clear();

            Queue<ClaimEntry> nextClaim = _repo.GetContents();

            Console.WriteLine("Total number of claims: ");

            Console.WriteLine(nextClaim.Count);

            nextClaim.Peek();

           foreach (ClaimEntry entry in nextClaim)
            {
                Console.WriteLine($"Claim ID: {entry.ClaimID}\n" +
                    $"Claim Type: {entry.ClaimType}\n" +
                    $"Claim Description: {entry.ClaimDescription}\n" +
                    $"Claim Amount: {entry.ClaimAmount}\n" +
                    $"Date of incident: {entry.DateOfIncident}\n" +
                    $"Date of Claim: {entry.DateOfClaim}\n" +
                    $"Valid claim: {entry.IsValid}");
            }

            Console.ReadLine();
        }

        public void CreateNewClaim()
        {
            Console.Clear();

            ClaimEntry entry = new ClaimEntry();

            Console.WriteLine("Please enter claim number: ");
            entry.ClaimID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the claim type: ");
            entry.ClaimType = Console.ReadLine();

            Console.WriteLine("Please enter a brief description of this claim: ");
            entry.ClaimDescription = Console.ReadLine();

            Console.WriteLine("Please enter claim amount: ");
            entry.ClaimAmount = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter date of incident: ");
            entry.DateOfIncident = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Please enter date claim was filed: ");
            entry.DateOfClaim = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("This is a valid claim: ");
            entry.IsValid = Convert.ToBoolean(Console.ReadLine());

            _repo.AddItemToDirectory(entry);
        }



        private void SeedData()
        {
            ClaimEntry entryOne = new ClaimEntry(1, "Auto", "Accident", 234.76, new DateTime(2020, 12, 20), new DateTime(2020, 12, 25), true);
            _repo.AddItemToDirectory(entryOne);

            ClaimEntry entryTwo = new ClaimEntry(2, "Home", "Flooding", 34857.86, new DateTime(2020, 10, 03), new DateTime(2019, 02, 11), true);
            _repo.AddItemToDirectory(entryTwo);

            ClaimEntry entryThree = new ClaimEntry(3, "Theft", "Burglary", 182.45, new DateTime(2018, 04, 30), new DateTime(2014, 10, 06), true);
            _repo.AddItemToDirectory(entryThree);
        }
    }
}
