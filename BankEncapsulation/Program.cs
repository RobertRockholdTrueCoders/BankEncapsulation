namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount();
            Console.WriteLine("How Much Would You Like to Deposit?");
            var depositAmount = double.Parse(Console.ReadLine());
            account.Deposit(depositAmount);
            Console.WriteLine($"Your account balance is {account.GetBalance()}");
        }
    }
}
