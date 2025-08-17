// Add more constructors to TwoDShape.
using System;
class TwoDShape2
{
    double pri_width;
    double pri_height;
    // Default constructor.
    public TwoDShape2()
    {
        Width = Height = 0.0;
    }
    // Constructor for TwoDShape.
    public TwoDShape2(double w, double h)
    {
        Width = w;
        Height = h;
    }
    // Construct object with equal width and height.
    public TwoDShape2(double x)
    {
        Width = Height = x;
    }
    // Properties for Width and Height.
    public double Width
    {
        get { return pri_width; }
        set { pri_width = value < 0 ? -value : value; }
    }
  
 public double Height
    {
        get { return pri_height; }
        set { pri_height = value < 0 ? -value : value; }
    }
    public void ShowDim()
    {
        Console.WriteLine("Width and height are " +
        Width + " and " + Height);
    }
}
// A derived class of TwoDShape for triangles.
class Triangle2 : TwoDShape
{
    string Style;
    /* A default constructor. This automatically invokes
    the default constructor of TwoDShape. */
    public Triangle2()
    {
        Style = "null";
    }
    // Constructor that takes three arguments.
    public Triangle2(string s, double w, double h) : base(w, h)
    {
        Style = s;
    }
    // Construct an isosceles triangle.
    public Triangle2(double x) : base(x)
    {
        Style = "isosceles";
    }
    // Return area of triangle.
    public double Area()
    {
        return Width * Height / 2;
    }
    // Display a triangle's style.
    public void ShowStyle()
    {
        Console.WriteLine("Triangle is " + Style);
    }
}
class Shapes5
{
    static void Main()
    {
        Triangle2 t1 = new Triangle2();
        Triangle2 t2 = new Triangle2("right", 8.0, 12.0);
        Triangle2 t3 = new Triangle2(4.0);
        t1 = t2;
        Console.WriteLine("Info for t1: ");
        t1.ShowStyle();
        t1.ShowDim();
        Console.WriteLine("Area is " + t1.Area());
        Console.WriteLine();
 Console.WriteLine("Info for t2: ");
        t2.ShowStyle();
        t2.ShowDim();
        Console.WriteLine("Area is " + t2.Area());
        Console.WriteLine();
        Console.WriteLine("Info for t3: ");
        t3.ShowStyle();
        t3.ShowDim();
        Console.WriteLine("Area is " + t3.Area());
        Console.WriteLine();
    }
}