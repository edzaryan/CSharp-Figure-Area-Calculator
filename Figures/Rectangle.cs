
public class Rectangle : Figure
{
    private double Width;
    private double Height;

    public Rectangle(double w, double h) 
    {
        Width = w;
        Height = h;
    }

    public override double GetArea() => Width * Height;
}