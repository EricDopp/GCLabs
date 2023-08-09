namespace Lab9_CircleObjects;

public class Circle
{
    private double radius { get; set; }
    public Circle(double radius)
    {
        this.radius = radius;
        Console.WriteLine("");
        Console.WriteLine($"The diameter is: {CalculateDiameter()}");
        Console.WriteLine($"The circumference is: {CalculateCircumference()}");
        Console.WriteLine($"The area is: {CalculateArea()}");
        Console.WriteLine("");
        Grow();
    }
    public double CalculateDiameter()
    {
        return this.radius * 2;
    }
    public double CalculateCircumference()
    {
        return CalculateDiameter() * Math.PI;
    }
    public double CalculateArea()
    {
        return Math.PI * (this.radius * this.radius);
    }
    public void Grow()
    {
        bool userContinue = true;
        Console.Write("Should the circle grow? (y/n): ");
        string userInput = Console.ReadLine();
        while (userContinue)
        {
            if (userInput.ToLower() == "y")
            {
                Console.WriteLine("The circle is magically growing.");
                this.radius += this.radius;
                Circle circle = new Circle(this.radius);
                break;
            }
            else if (userInput.ToLower() == "n")
            {
                Console.WriteLine($"Goodbye. The circle's final radius is {this.radius}");
                break;
            }
            else
            {
                Console.WriteLine("Please input 'y' or 'n'.");
                userInput = Console.ReadLine();
            }
        }
    }
    public static double GetRadius(double radius)
    {
        return radius;
    }
}
