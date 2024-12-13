//voilation code
/*
public class AreaCalculator
{
    public double CalculateArea(string shape, double length, double width = 0)
    {
        if (shape == "Rectangle")
        {
            return length * width;
        }
        else if (shape == "Circle")
        {
            return Math.PI * length * length;
        }
        // Adding a new shape requires modifying this method.
        else if (shape == "Triangle")
        {
            return 0.5 * length * width;
        }
        else
        {
            throw new ArgumentException("Invalid shape");
        }
    }
}


*/

public interface IShape{
    double CalculateArea();
}

public class Rectangle: IShape{
    public double Length { get; set; }
    public double Width { get; set; }

    public Rectangle(double length, double width)
    {
        Length = length;
        Width = width;
    }

    public double CalculateArea()
    {
        return Length * Width;
    }
}

// Implement Circle class
public class Circl : IShape
{
    public double Radi { get; set; }

    public Circl(double radius)
    {
        Radi = radius;
    }

    public double CalculateArea()
    {
        return Math.PI * Radi * Radi;
    }
}

// Implement Triangle class
public class Triangle : IShape
{
    public double BaseLength { get; set; }
    public double Height { get; set; }

    public Triangle(double baseLength, double height)
    {
        BaseLength = baseLength;
        Height = height;
    }

    public double CalculateArea()
    {
        return 0.5 * BaseLength * Height;
    }
}

// AreaCalculator works with any IShape without modification
public class AreaCalculator
{
    public double GetArea(IShape shape)
    {
        return shape.CalculateArea();
    }
}