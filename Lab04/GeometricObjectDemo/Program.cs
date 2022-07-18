public abstract class GeometricObject
{
    protected string color;
    protected double weight;

    protected GeometricObject()
    {
        color = "white";
        weight = 1.0;
    }
    public string PColor
    {
        get { return color; }
        set { color = value; }
    }
    public double PWeight
    {
        get { return weight; }
        set { weight = value; }
    }
    public abstract double findArea();

    public abstract double findPerimeter();
}

public class Circle : GeometricObject
{
    private double radius;
    public Circle(double x)
    {
        this.radius = x;
    }
    public Circle(double x, string c, double w) : base(c, w)
    {
        this.radius = x;
    }

    public override double findArea() { return Math.PI*radius*radius; }

    public override double findPerimeter() { return 2 * Math.PI*radius; }
}

public class Program
{
    static void Main(string[] args)
    {
        Circle c1 = new Circle(2.45, "Blue", 23);
        Console.WriteLine("Circle before change: "+c1.ToString());

        c1.PColor = "red";
        c1.PWeight = 2.8;
        
        Console.WriteLine("Circle after change: "+ c1.ToString());
        Console.ReadLine();
    }
}