static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        if (balance < 0) return (float)3.213;
        else if (balance >= 0 && balance < 1000) return (float)0.5;
        else if (balance >= 1000 && balance < 5000) return (float)1.621;
        else if (balance >= 5000) return (float)2.475;
        else return (float)0;
    }

    public static decimal Interest(decimal balance)
    {
        return balance * (decimal)InterestRate(balance) / 100;
    }

    public static decimal AnnualBalanceUpdate(decimal balance)
    {
        return balance + Interest(balance);
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int years = 0;
        while (balance < targetBalance)
        {
            balance = AnnualBalanceUpdate(balance);
            years++;
        }
        return years;
    }
}
