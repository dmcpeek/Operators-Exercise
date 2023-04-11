using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorExercise
{
    internal class Methods
    {
        static public void AreaOfCircle()
        {
            Console.WriteLine("What is the radius of your circle ?");
            var radius = double.Parse(Console.ReadLine());
            double area = Math.PI * radius * radius;
            Console.WriteLine($"The area of a circle with a radius of {radius} is {area}");
        }
    }
}
