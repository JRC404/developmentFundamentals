using System;

Rectangle rectangle = new Rectangle(10.0, 15.0);
double area = rectangle.GetArea();

Console.WriteLine("Area of rectangle is: {0}", area);

Rectangle rectangle2 = new Rectangle();
rectangle2.InitFields(2.5, 3.5);
double area2 = rectangle2.GetArea();

Console.WriteLine("Area of rectangle is: {0}", area2);

Console.ReadKey();