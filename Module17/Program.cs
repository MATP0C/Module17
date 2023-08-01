

namespace Module17
{
    public class Account
    {
        public string AccountType { get; set; }
        public double AccountBalance { get; set; }
        public double Rate { get; set; }
    }

    public static class Calculator
    {
        private const double DefaultBalance = 100;

        public static double CalculateInterest(Account account)
        {
            if (account == null)
            {
                throw new ArgumentNullException(nameof(account));
            }
            var type = account.AccountType;
            double balance = account.AccountBalance;

            return CalculateInterest(type, balance);
        }

        private static double CalculateInterest(string accountType, double balance)
        {
            switch (accountType)
            {
                case "Обычный":
                    if (balance <= DefaultBalance)
                    {
                        return balance * 0.8;
                    }
                    else if (balance > DefaultBalance && balance <= 1000)
                    {
                        return balance * (0.8 + (balance - DefaultBalance) / 500);
                    }
                    return balance * 0.5;
                default:
                    throw new ArgumentException($"Неизвестный тип учетной записи: {accountType}", nameof(accountType));
            }
        }
    }
}