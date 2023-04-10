namespace BankEncapsulation
{
    public class Program
    {
       

            static void Main(string[] args)
            {
            var account = new BankAccount();

            Console.WriteLine("How much would you like to deposit?");

            double depositAmount = double.Parse(Console.ReadLine());

            account.Deposit(depositAmount);

            Console.WriteLine($"Thank you! Your balance is now ${account.GetBalance()}");






               
            }

        
    }
}
