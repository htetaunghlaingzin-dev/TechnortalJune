// See https://aka.ms/new-console-template for more information
using System;

Rectangle rc = new Rectangle(10, 5);
Triangle triangle = new Triangle(10, 5);

Console.WriteLine($"Rectangle area (10 x 5): {rc.Area()}");
Console.WriteLine($"Triangle area (10 x 5): {triangle.Area()}");

Console.WriteLine("Press Enter to exit...");
Console.ReadLine();
// Base class Shape with protected integer attributes width and height
class Shape
{
    protected int width;
    protected int height;

    // Two-argument constructor
    public Shape(int width, int height)
    {
        this.width = width;
        this.height = height;
    }

    // Virtual method Area that can be overridden by derived classes
    public virtual int Area()
    {
        return width * height; // default area behavior
    }
}

// Rectangle inherits from Shape
class Rectangle : Shape
{
    public Rectangle(int width, int height) : base(width, height)
    {
    }

    // Override Area for rectangle (width * height)
    public override int Area()
    {
        return width * height;
    }
}

// Triangle inherits from Shape
class Triangle : Shape
{
    public Triangle(int width, int height) : base(width, height)
    {
    }

    // Override Area for triangle (width * height / 2)
    public override int Area()
    {
        return (width * height) / 2;
    }
}
        

        // IDE0090: use target-typed new (C# 9+)
       
