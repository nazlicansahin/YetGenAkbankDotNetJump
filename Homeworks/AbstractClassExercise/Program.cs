using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassExercise
{
    abstract class Shape
    {
        internal abstract double CalculateArea();
        internal void Display()
        {
            Console.WriteLine("This is a shape.");
        }
    }
    class Rectangle : Shape
    {
        double length;
        double width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        internal override double CalculateArea() => length * width;


    }

    class Circle : Shape
    {
        double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }

        internal override double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
    }
    public class Program
    {

        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(5, 3);
            Circle circle = new Circle(4);

            rectangle.Display();
            Console.WriteLine("Area of rectangle: " + rectangle.CalculateArea());

            circle.Display();
            Console.WriteLine("Area of circle: " + circle.CalculateArea());
            Console.ReadLine();


        }
    }
}
