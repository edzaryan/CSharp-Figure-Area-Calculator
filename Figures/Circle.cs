
public class Circle : Figure
{
    private double Radius;

    public Circle(double r) 
    {
        Radius = r;
    }

    public override double GetArea() => Math.PI * Radius * Radius;
}