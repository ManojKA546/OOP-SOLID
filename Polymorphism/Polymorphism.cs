class Animal  // Base class (parent) 
{
  public  virtual void animalSound() 
  {
    Console.WriteLine("The animal makes a sound");
  }
}

class Cow : Animal  // Derived class (child) 
{
  public override void animalSound() 
  {
    Console.WriteLine("The cow sound");
  }
}

/*    override and virtual combo should be used 
class Dog : Animal  // Derived class (child) 
{
  public  void animalSound() 
  {
    Console.WriteLine("The dog sound");
  }
}
*/

// Polymorphism by using interface  , Override is not required
public  interface IPayment
{
    void ProcessPayment();
}

public   class CreditCardPayment : IPayment
{
    public void ProcessPayment()
    {
        Console.WriteLine("Processing credit card payment...");
    }
}

public class PayPalPayment : IPayment
{
    public void ProcessPayment()
    {
        Console.WriteLine("Processing PayPal payment...");
    }
}
