using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

static class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please choose a shape to calculate the area:\n1. Circle\n2. Triangle\n3. Rectabgle\n4. Square");
        var selection = Console.ReadLine();

        switch (selection)
        {
            case "1":
                CircleArea();
                break;
            case "2":
                TriangleArea();
                break;
            case "3":
                RectangleArea();
                break;
            case "4":
                SquareArea();
                break;
            default:
                Console.WriteLine("Invalid entry. Please enter a number.");
                break;
        }
        
        static void CircleArea()
        {
            Console.WriteLine("Enter the radius of the circle:");
            double radius = Convert.ToDouble(Console.ReadLine());
            
            double areaC = Math.PI * radius * radius;
           Console.WriteLine($"Area = {areaC}");
        }

        static void TriangleArea()
        {
            Console.WriteLine("Enter the base length of the triangle:");
            double baseLength = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Enter the height of the triangle:");
            double height = Convert.ToDouble(Console.ReadLine());
            
            double areaT = 0.5 * baseLength * height;
            Console.WriteLine($"Area = {areaT}");
        }

        static void RectangleArea()
        {
            Console.WriteLine("Enter the length of the ractabgle:");
            double length = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Enter the width of the rectangle:");
            double width = Convert.ToDouble(Console.ReadLine());

            double areaR = length * width;
            Console.WriteLine($"{areaR = areaR}");
        }

        static void SquareArea()
        {
            Console.WriteLine("Enter the side length of the square:");
            double side = Convert.ToDouble(Console.ReadLine());    

            double areaS = side * side;
            Console.WriteLine($"Area = {areaS}");
        }
    }
}

