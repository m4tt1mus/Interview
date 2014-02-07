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
            foreach (var fizzBuzz in fb.Run().Take(100))
            {
                Console.WriteLine(fizzBuzz);
            }

            Console.ReadKey();
        }
    }
}
