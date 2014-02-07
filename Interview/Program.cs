using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;

namespace Interview
{
    class Program
    {
        public static void Main(string[] args)
        {
            var fb = new FizzBuzz();
            var fizzBuzzes = fb.Run().Take(100).ToList();
            foreach (var fizzBuzz in fizzBuzzes)
            {
                Console.WriteLine(fizzBuzz);
            }

            Console.ReadKey();
        }
    }
}
