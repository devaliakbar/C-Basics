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

            Console.Clear();
            Console.WriteLine("Accounts :\n");

            foreach (var account in accounts)
            {
                Console.WriteLine("Account name : " + account.accountName
                    + "\nAccount number : " + account.accountNumber
                    + "\nDate of birth : " + account.birthday.ToString("dd/mm/yyyy")
                    + "\nBalance : " + account.balance);

                Console.WriteLine("\n");
            }

            ShowMenu();
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
            Console.Clear();
            Console.WriteLine("***Delete account***\nPlease enter your account number :");
            int accountNumber = int.Parse(Console.ReadLine() ?? "0");
            int indexOfAcc = accounts.FindIndex((obj) => obj.accountNumber == accountNumber);

            if(indexOfAcc == -1)
            {
                Console.Clear();
                Console.WriteLine("Account number doesn't exist");

                ShowMenu();
                return;
            }

            accounts.RemoveAt(indexOfAcc);

            Console.Clear();
            Console.WriteLine("Account number '" + accountNumber + "' deleted successfully");
            ShowMenu();
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