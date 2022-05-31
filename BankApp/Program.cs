using System.Globalization;

namespace BankApp
{
    class Program
    {
        static List<AccountDetails> accounts = new();

        static void Main(string[] args)
        {
            ShowMenu();

            while (true)
            {
                string input = Console.ReadLine() ?? "";
                switch (input)
                {
                    case "0":
                        Console.Clear();
                        ShowMenu();
                        break;

                    case "1":
                        ListAccount();
                        break;

                    case "2":
                        CreateAccount();
                        break;

                    case "3":
                        DeleteAccount();
                        break;

                    case "4":
                        CreditAmount();
                        break;


                    case "5":
                        DebitAmount(); break;

                    default:
                        ShowMenu();
                        Console.WriteLine("Please select a valid option");
                        break;
                }
            }
        }


        static void ShowMenu()
        {
            Console.WriteLine("***Please select an option***" +
                "\n0 : Clear console" +
                "\n1 : List accounts" +
                "\n2 : Create account" +
                "\n3 : Delete account" +
                "\n4 : Credit amount" +
                "\n5 : Debit amount");
        }

        static void ListAccount()
        {

            Console.WriteLine("List accounts");
        }

        static void CreateAccount()
        {
            Console.Clear();

            Console.WriteLine("***Create account***\nPlease enter your full name :");
            string fullName = (Console.ReadLine() ?? "").Trim();

            Console.WriteLine("Please enter your birthday(dd/mm/yyyy) :");
            string birthdayStr = (Console.ReadLine() ?? "").Trim();
            DateTime birthday = DateTime.ParseExact(birthdayStr, "dd/mm/yyyy", CultureInfo.InvariantCulture);

            int accountNumber = accounts.Count == 0 ? 1 : (accounts.Last().accountNumber + 1);

            accounts.Add(new AccountDetails(accountNumber, fullName, birthday));

            Console.Clear();
            Console.WriteLine("Congrats " + fullName + ", your account created successfully. Your account number is " + accountNumber);

            ShowMenu();

        }

        static void DeleteAccount()
        {

            Console.WriteLine("Delete account");
        }

        static void CreditAmount()
        {

            Console.WriteLine("Credit amount");
        }

        static void DebitAmount()
        {

            Console.WriteLine("Debit amount");
        }
    }
}