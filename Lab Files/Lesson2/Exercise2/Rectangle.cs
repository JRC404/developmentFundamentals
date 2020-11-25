public class Rectangle
{
	private double length;
	private double width;

	// Empty Constructor

	public Rectangle(double l, double w)
	{
		this.length = l;
		this.width = w;
	}

	// Init Method

	public double GetArea()
	{
		return this.length * this.width;
	}
}