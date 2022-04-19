using System;

namespace OperatorExercise2 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the radius of your circle ?");
            var radius = double.Parse(Console.ReadLine());
            Console.WriteLine($"Area is {AreaOfCircle(radius)}");
        }
        public static double AreaOfCircle(double radius) 
        {
            var area = (Math.PI * radius * radius);
            return area;
        }
    }
}


