namespace BankApp
{
    public class AccountDetails
    {
        public int accountNumber;
        public string accountName;
        public DateTime birthday;
        public double balance = 0;

        public AccountDetails(int mAccountNumber, string mAccountName, DateTime mBirthday)
        {
            accountNumber = mAccountNumber;
            accountName = mAccountName;
            birthday = mBirthday;
        }
    }
}

