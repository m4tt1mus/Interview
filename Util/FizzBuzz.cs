using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
    public class FizzBuzz
    {
        public static IEnumerable<string> Run()
        {
            long i = 1;
            yield return i.ToString();

            while (true)
            {
                i++;

                if (i % 3 == 0 && i % 5 == 0)
                {
                    yield return "FizzBuzz";
                }
                else if (i % 3 == 0)
                {
                    yield return "Fizz";
                }
                else if (i % 5 == 0)
                {
                    yield return "Buzz";
                }
                else
                {
                    yield return i.ToString();
                }
            }
        }
    }
}
