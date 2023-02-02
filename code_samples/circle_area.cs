using System;

namespace circle_area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter radius =");
            double radius = double.Parse(Console.ReadLine());

            double area = Math.PI * radius * radius;

            Console.WriteLine("The area = : " + area);
            Console.ReadLine();
        }
    }
}
