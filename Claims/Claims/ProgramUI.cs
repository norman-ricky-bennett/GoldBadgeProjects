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


        Queue claimQueue = new Queue();

        public bool continueToRun = true;
        public void Run()
        {
            SeedData();

            bool continueToRun = true;


            while (continueToRun)
            {
            Console.WriteLine("Welcome to Komodo Virtual Claims.\n" +
                "Please select an option from the menu: \n" +
                "1. View All Claims\n" +
                "2. View Next Claim\n" +
                "3. Delete Existing Claim");

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

            Queue<ClaimEntry> queueOfClaims = _repo.GetContents();

            foreach (ClaimEntry entry in queueOfClaims)
            {
                queueOfClaims.Enqueue(entry);
                Console.WriteLine(claimQueue);
            }

        }

        public void ViewNextClaim()
        {
            
        }

        public void CreateNewClaim()
        {

        }



        private void SeedData()
        {
            ClaimEntry entryOne = new ClaimEntry(1, "Auto", "Single vehicle accident", 234.76, new DateTime(2020, 12, 20), new DateTime(2020, 12, 25), true);
            _repo.AddItemToDirectory(entryOne);

            ClaimEntry entryTwo = new ClaimEntry(2, "Home", "Flooding", 34857.86, new DateTime(2020, 10, 03), new DateTime(2019, 02, 11), true);
            _repo.AddItemToDirectory(entryTwo);

            ClaimEntry entryThree = new ClaimEntry(3, "Theft", "Burglary", 182.45, new DateTime(2018, 04, 30), new DateTime(2014, 10, 06), true);
            _repo.AddItemToDirectory(entryThree);
        }
    }
}
