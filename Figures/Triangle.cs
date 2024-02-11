
public class Triangle : Figure
{
    private double baseSide;
    private double height;

    public Triangle(double b, double h)
    {
        baseSide = b;
        height = h;
    }

    public override double GetArea() => (baseSide * height) / 2;
}