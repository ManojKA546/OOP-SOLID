using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World! i am Manoj");
        
        //Encapsulation

        BankAccount b=new BankAccount("Manoj", 5000);
        b.Deposite(2000);
        b.Withdraw(6000);

        Console.WriteLine(b.x);
        // b.balance cannot be accessed

        //Inheritance

         // Create a myCar object
         Car myCar = new Car();

        // Call the honk() method (From the Vehicle class) on the myCar object
        myCar.honk();

         // Display the value of the brand field (from the Vehicle class) and the value of the modelName from the Car class
         Console.WriteLine(myCar.brand + " " + myCar.modelName);

         //Polymorphism
         
         Animal myAnimal = new Animal();  // Create a Animal object
        Animal mycow = new Cow();  // Create a Pig object
        //Animal myDog = new Dog();  // Create a Dog object

         myAnimal.animalSound();
         mycow.animalSound();
        // myDog.animalSound();
        CreditCardPayment ccp=new CreditCardPayment();
        PayPalPayment ppp=new PayPalPayment();
        ccp.ProcessPayment();
        ppp.ProcessPayment();

        

         //ABSTRUCTION

         //Shape S =new Shape();  error obj cannot be created

         Circle C =new Circle(5);
         C.Area();
         Console.WriteLine(C.Radius);
         double R= C.CalculateArea();
         Console.WriteLine(R);

          
          //SRP (Single Responsibility Principle)
           ReportGenerator rr= new ReportGenerator();
          Report r= rr.GenerateReport();
          ReportSaver rs= new ReportSaver();
          rs.SaveToFile(r,"manoj");
          ReportSender rg= new ReportSender();
          rg.SendToEmail(r,"manoj@gmail.com");

         

           //OCP polymorpism Single Responsibility Principle
          IShape ish=new Rectangle(5,6);
          Console.WriteLine("area of Rectangle");
          Console.WriteLine(ish.CalculateArea());
          ish =new Circl(5);
          Console.WriteLine("area of Circle");
          Console.WriteLine(ish.CalculateArea());
          ish=new Triangle(6,7);
          Console.WriteLine("area of Triangle");
          Console.WriteLine(ish.CalculateArea());
          //
          //OCP  Single Responsibility Principle
          IShape rectang= new Rectangle(5,6);
          IShape circle= new Circl(5);
          IShape triangle= new Triangle(5,6);

          AreaCalculator calc =new AreaCalculator();
          Console.WriteLine($"Rectangle Area: {calc.GetArea(rectang)}");
        Console.WriteLine($"Circle Area: {calc.GetArea(circle)}");
        Console.WriteLine($"Triangle Area: {calc.GetArea(triangle)}");
       

        //LSP(Liskov Substitution Principle)
        Bird bird = new Penguin();
        bird.Fly(); 

        //Interface Segregation Principle(ISP)
        MultiFunctionPrinter mp=new MultiFunctionPrinter();
        mp.Print();
        mp.Scan();
        
         

         //Dependency Inversion Principle (DIP)
        IMessageService emailService = new EmailService();
        Notification emailNotification = new Notification(emailService);
        emailNotification.Send("Hello via Email!");

        IMessageService smsService = new SmsService();
        Notification smsNotification = new Notification(smsService);
        smsNotification.Send("Hello via SMS!");
        

    }
}
