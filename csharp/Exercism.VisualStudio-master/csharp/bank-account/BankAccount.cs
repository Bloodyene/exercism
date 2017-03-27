using System;
using System.Threading;

public class BankAccount
{
    private float balance;
    bool access = false;
    public void Open()
    {
        access = true;
        balance = 0;
    }

    public void Close()
    {
        access = false;
    }

    public float Balance
    {
        get
        {
            if (access)
            {
                 return balance;
            }
            throw new InvalidOperationException();
        }
    }

    public void UpdateBalance(float change)
    {
        lock (this)
        {
            balance += change;
        }
        
    }
}
