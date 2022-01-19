using System;
using csharp.project_euler;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var ProjectEulerProblems = new Problems();

            while (Console.ReadLine() != "quit")
            {
                Console.WriteLine($"Project Euler Problem 1 Solution: {ProjectEulerProblems.Problem1()}");
                Console.WriteLine($"Project Euler Problem 2 Solution: {ProjectEulerProblems.Problem2()}");
                Console.WriteLine($"Project Euler Problem 3 Solution: {ProjectEulerProblems.Problem3()}");
                Console.WriteLine($"Project Euler Problem 4 Solution: {ProjectEulerProblems.Problem4()}");
                Console.WriteLine($"Project Euler Problem 5 Solution: {ProjectEulerProblems.Problem5()}");
                Console.WriteLine($"Project Euler Problem 6 Solution: {ProjectEulerProblems.Problem6()}");
                Console.WriteLine($"Project Euler Problem 7 Solution: {ProjectEulerProblems.Problem7()}");
                Console.WriteLine($"Project Euler Problem 8 Solution: {ProjectEulerProblems.Problem8()}");
                Console.WriteLine($"Project Euler Problem 9 Solution: {ProjectEulerProblems.Problem9()}");
                Console.WriteLine($"Project Euler Problem 10 Solution: {ProjectEulerProblems.Problem10()}");
            }
        }
    }
}
