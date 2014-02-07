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

            foreach (var output in fb.Run().Take(100).ToList())
            {
                Console.WriteLine(output);
            }

            Console.ReadKey();
        }
    }
}
