//using System;

//namespace ShapeDemo
//{
    
//    public class Shape
//    {
//        // Properties for Length and Breadth
//        public double Length { get; set; }
//        public double Breadth { get; set; }

//        // Default constructor
//        public Shape()
//        {
//            Length = 0;
//            Breadth = 0;
//            //Console.WriteLine("Shape created with default values.");
//        }

//        // Parameterized constructor
//        public Shape(double length, double breadth)
//        {
//            Length = length;
//            Breadth = breadth;
//            //Console.WriteLine($"Shape created with Length = {Length} and Breadth = {Breadth}");
//        }
//    }

//    // Derived class: Rectangle (inherits from Shape)
//    public class Rectangle : Shape
//    {
//        // Constructor calling base class constructor
//        public Rectangle(double length, double breadth) : base(length, breadth)
//        {
//        }

//        // Method to calculate the area of the rectangle
//        public double CalculateArea()
//        {
//            return Length * Breadth;
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // Create an object of Shape using default constructor
//            Shape shape1 = new Shape();
//            Console.WriteLine($"Default Shape: Length = {shape1.Length}, Breadth = {shape1.Breadth}\n");

//            // Create an object of Shape using parameterized constructor
//            Shape shape2 = new Shape(5, 3);
//            Console.WriteLine($"Parameterized Shape: Length = {shape2.Length}, Breadth = {shape2.Breadth}\n");

//            // Create an object of Rectangle (derived class) and calculate its area
//            Rectangle rectangle = new Rectangle(10, 5);
//            Console.WriteLine($"Rectangle: Length = {rectangle.Length}, Breadth = {rectangle.Breadth}");
//            Console.WriteLine($"Area of Rectangle = {rectangle.CalculateArea()}\n");
//        }
//    }
//}
