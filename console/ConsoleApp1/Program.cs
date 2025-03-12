using System;

class Program
{

    //Домашняя работа 
    //обязательная часть
    static void Main(string[] args)
    {
        double balance = 100;
        (double newBalance, double bankProfit) = InterestCalculation(50, balance);
        Console.WriteLine($"Баланс после снятия: {newBalance}, прибыль банка: {bankProfit}");

        balance = DepositWithdrawal(50, newBalance);
        Console.WriteLine($"Баланс после вклада: {balance}");

        string loanStatus = LoanApproval(balance);
        Console.WriteLine(loanStatus);
    }

    static string LoanApproval(double balance)
    {
        if (balance <= 0)
        {
            return "Кредит одобрен!";
        }
        else
        {
            return "У вас достаточно средств, кредит не нужен.";
        }
    }

    static (double, double) InterestCalculation(double amountToWithdraw, double balance)
    {
        double interest = amountToWithdraw * 0.05;
        double newBalance = balance - interest;
        double bankProfit = interest;
        return (newBalance, bankProfit);
    }
    
    // продвинутая
    static double DepositWithdrawal(double deposit, double balance)
    {
        return balance - deposit;
    }
    static double CalculateCompoundInterest(double principal, double annualInterestRate, int years)
{
    double amount = principal * Math.Pow(1 + annualInterestRate, years);
    return amount;
}
}