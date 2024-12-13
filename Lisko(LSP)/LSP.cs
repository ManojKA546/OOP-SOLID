public class Bird
{
    public virtual void Fly()
    {
        Console.WriteLine("The bird is flying.");
    }
}

public class Penguin: Bird{

    public override void Fly()
    {
        Console.WriteLine("Penguins cannot fly!");
    }
}