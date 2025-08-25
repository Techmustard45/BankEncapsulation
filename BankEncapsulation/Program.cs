namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount myAccount = new BankAccount();
            
            myAccount.Deposit(987);
            Console.WriteLine(myAccount.GetBalance());
            myAccount.Deposit(1000);
            Console.WriteLine(myAccount.GetBalance());
        }
    }
}
