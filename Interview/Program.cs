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
            foreach (var output in FizzBuzz.Run().Take(100))
            {
                Console.WriteLine(output);
            }

            Console.ReadKey();
        }
    }
}
