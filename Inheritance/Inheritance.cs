class Vehicle  // base class (parent) 
{
  public string brand = "Ford";  // Vehicle field
  public void honk()             // Vehicle method 
  {                    
    Console.WriteLine("Tuut, tuut!");
  }
}

class Car : Vehicle  // derived class (child)
{
  public string modelName = "Mustang";  // Car field
}


//sealed not let to inherite
sealed  class Train{
public string model = "Metro";  // Vehicle field
  public void speed()             // Vehicle method 
  {                    
    Console.WriteLine("100km/hr");
  }
}

/*
class Normal_train : Train{}

*/