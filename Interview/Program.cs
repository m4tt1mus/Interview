using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Interview
{
    class Program
    {
        public static void Main(string[] args)
        {
            var fb = new FizzBuzz.FizzBuzz();
            IEnumerable<string> outputs = fb.Run(100, 1);
            foreach (var output in outputs)
            {
                Console.WriteLine(output);
            }
            Console.ReadKey();
        }
    }
}
