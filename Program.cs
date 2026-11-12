
using System;
using System.Collections.Generic;

public interface IPayment
{
    bool ProcessPayment(decimal amount);
    string GetPaymenetType();
}

public class CreditCardPayment : IPayment
{
    public bool ProcessPayment(decimal amount)
    {
        return amount > 0;
    }

    public string GetPaymenetType()
    {
        return "Credit Card";
    }
}

public class PayPalPayment : IPayment
{
    public bool ProcessPayment(decimal amount)
    {
        return amount > 0;
    }

    public string GetPaymenetType()
    {
        return "PayPal";
    }
}

public class BankTransferPayment : IPayment
{
    public bool ProcessPayment(decimal amount)
    {
        return amount > 0;
    }

    public string GetPaymenetType()
    {
        return "Bank Transfer";
    }
}


public class BankAccount
{
    private decimal _balance;

    public decimal Balance
    {
        get { return _balance; }
        private set
        {
            if (value < 0)
                throw new ArgumentException("Balance cannot be negative.");
            _balance = value;
        }
    }

    public void Deposit(decimal amount, IPayment payementMethod)
    {
        if (payementMethod.ProcessPayment(amount))
        {
            Balance += amount;
            Console.WriteLine($"Deposited{amount} using {payementMethod.GetPaymenetType()}");
        }
    }
}





