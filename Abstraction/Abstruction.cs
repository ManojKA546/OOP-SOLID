public abstract class Shape
{
    public abstract double CalculateArea();

    public void Area(){
        Console.WriteLine("Hi , area is 2d");
    }
}

public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}
