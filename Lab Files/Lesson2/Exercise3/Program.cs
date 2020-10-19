using System;
Rectangle rectangle = new Rectangle(62,70);
Console.WriteLine($"The area of your rectangle is: {rectangle.GetArea()}");
Console.ReadKey();

// Add Polygon


class Rectangle
{
    public double Length { get; set; }
    public double Width { get; set; }

    public Rectangle(double length, double width)
    {
        Length = length;
        Width = width;
    }

    public double GetArea()
    {
        return Width * Length;
    }
}