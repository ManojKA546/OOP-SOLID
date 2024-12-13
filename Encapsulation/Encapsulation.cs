public class BankAccount
{
     private double balance;
     public int x=100;

     public string AccountHolder{ get;set;}

     public BankAccount(string accountholder,double initialBalance )
     {
         AccountHolder=accountholder;
         balance=initialBalance;
         Console.WriteLine(balance);
     }

     public void Deposite(double amount)
    {
        if (amount>0){
            balance+=amount;
            Console.WriteLine($"Deposited {amount}. New Balance {balance}");
        }
        else{
            Console.WriteLine("Amount should be positive");
        }

    }
    public void Withdraw(double amount)
    {
        if (amount > 0 && balance >= amount)
        {
            balance -= amount;
            Console.WriteLine($"Withdrew {amount}. Remaining balance: {balance}");
        }
        else
        {
            Console.WriteLine("Invalid withdraw amount or insufficient balance.");
        }
    }
}