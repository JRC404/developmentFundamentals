using System;
using System.Collections.Generic;

List<Polygon> polygons = new List<Polygon>();
polygons.Add(new Polygon());
polygons.Add(new Rectangle ());
// Add Triagle
// Add Star

foreach (Polygon p in polygons)
{
    p.Draw();
}

Console.ReadKey();

// Add Polygon

class Polygon
{
	public virtual void Draw()
	{
		Console.WriteLine("Drawing: Polygon");
	}
}

class Rectangle : Polygon
{
	public override void Draw()
	{
		Console.WriteLine("Drawing: Rectangle");
	}
}
