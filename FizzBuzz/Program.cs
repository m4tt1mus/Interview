using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class Program
    {
        //public IEnumerable<string> Run()
        //{
        //    return Run().Take(1);
        //}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public static IEnumerable<string> Run()
        {
            long i = 1;
            yield return i.ToString();

            while (true)
            {
                i++;
                yield return i.ToString();
            }
            //for (int i = start; i < end + 1; i++)
            //{
            //    if (i % 3 == 0 && i % 5 == 0)
            //    {
            //        yield return "FizzBuzz";
            //    }
            //    else if (i % 3 == 0)
            //    {
            //        yield return "Fizz";
            //    }
            //    else if (i % 5 == 0)
            //    {
            //        yield return "Buzz";
            //    }
            //    else
            //    {
            //        yield return i.ToString();
            //    }

        }
    }
}
