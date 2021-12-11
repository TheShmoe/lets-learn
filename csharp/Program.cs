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
            }
        }
    }
}
