using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // A simple console test.
            Console.WriteLine(Solve("1 2"));
        }

        /// <summary>
        /// This is the entry point to your solution. You can add whatever code and classes you need (within the
        /// security restrictions), but just be sure this method exists to accept and return a string.
        /// </summary>
        /// <param name="input">The input for the test case.</param>
        /// <returns>The output to test.</returns>
        static public string Solve(string input)
        {
            string[] parts = input.Split(' ');
            return (int.Parse(parts[0]) + int.Parse(parts[1])).ToString();
        }
    }
}
