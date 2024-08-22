namespace BankEncapsulation;

public class BankAccount
{
    private double _balance = 0;

    public void Deposit(double total)
    {
        _balance = total;
    }

    public double GetBalance()
    {
        return _balance;
    }
}