using System;

namespace Uni
{
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

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENter the width");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the height");
            int height = Convert.ToInt32(Console.ReadLine());
            Rectangle rc=new Rectangle(width, height);
            Triangle triangle=new Triangle(width, height);
            var tri = new Triangle(width, height);

            Console.WriteLine("Rectangle area: "+rc.Area());
            Console.WriteLine($"Triangle area: {tri.Area()}");

            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }
    }
}