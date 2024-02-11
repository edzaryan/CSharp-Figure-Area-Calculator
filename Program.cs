try 
{
    double area;
    Figure figure = null;

    Console.WriteLine("What shape would you like to find the area of? (t - triangle | r - rectangle | c - circle)");
    char shapeType = Convert.ToChar(Console.ReadLine());

    switch (shapeType)
    {
        case 't':
            Console.WriteLine("Enter the triangle base width");
            double baseWidth = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the triangle height");
            double height = Convert.ToDouble(Console.ReadLine());
            figure = new Triangle(baseWidth, height);
            break;
        case 'r':
            Console.WriteLine("Enter the rectangle width");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the rectangle height");
            height = Convert.ToDouble(Console.ReadLine());
            figure = new Rectangle(width, height);
            break;
        case 'c':
            Console.WriteLine("Enter the circle radius");
            double radius = Convert.ToDouble(Console.ReadLine());
            figure = new Circle(radius);
            break;
        default:
            throw new ArgumentException("Invalid shape type entered.");
    }

    area = figure.GetArea();
    Console.WriteLine($"Area of the shape: {area}");
} 
catch (FormatException)
{
    Console.WriteLine("Invalid input format. Please enter a valid number.");
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}
catch (Exception)
{
    Console.WriteLine("Something went wrong!");
}
