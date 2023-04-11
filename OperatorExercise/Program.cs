namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1
            int x = 3, y = 6;
            Console.WriteLine($"{x} * {y} equals {x * y}");
            Console.WriteLine("");

            x = 3;
            y = 6;
            Console.WriteLine($"{x} - {y} equals {x - y}");
            Console.WriteLine("");

            x = 23581331;
            y = 31415926;
            Console.WriteLine($"{x} + {y} equals {x + y}");

            Console.WriteLine("----------------------------");
            Console.WriteLine("");

            int a= 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;
            if (a == 17 && b == 4)
                Console.WriteLine($"{a} % {b} has a remainder of {remainder}");
            Console.WriteLine($"{a} / {b} equals {quotient}");

            Console.WriteLine("----------------------------");
            Console.WriteLine("");

            ////Exercise 2
            Methods.AreaOfCircle();

        }
    }
}
