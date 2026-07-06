using System;

namespace Uni
{
    // Rectangle with protected double attributes length and width
    class Rectangle
    {
        protected double length;
        protected double width;

        // Two-argument constructor
        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        // GetArea method returns area as double
        public virtual double GetArea()
        {
            return length * width;
        }

        // Display method prints length, width and area
        public virtual void Display()
        {
            Console.WriteLine($"Length: {length}");
            Console.WriteLine($"Width: {width}");
            Console.WriteLine($"Area: {GetArea():F2}");
        }
    }

    // Tabletop inherits from Rectangle and adds a private cost attribute
    class Tabletop : Rectangle
    {
        private double cost;
        private const double unitPrice = 20.0; // price per square unit

        // Two-argument constructor accepting length and width
        public Tabletop(double length, double width) : base(length, width)
        {
            // calculate and store cost
            this.cost = GetCost();
        }

        // GetCost calculates cost based on area and returns double
        public double GetCost()
        {
            return GetArea() * unitPrice;
        }

        // Display method outputs length, width, area and cost
        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Cost: {cost:C2}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a Tabletop instance and display information
            var tabletop = new Tabletop(2.5, 1.2);
            tabletop.Display();

            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }
    }
}
