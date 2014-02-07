using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
    public class FizzBuzz
    {
        private readonly List<FizzBuzzRequest> _fizzBuzzRequests = new List<FizzBuzzRequest>()
                {
                    new FizzBuzzRequest()
                        {
                            Check = x => x % 15 == 0, 
                            Result = "FizzBuzz"
                        },
                    new FizzBuzzRequest()
                        {
                            Check = x => x % 3 == 0, 
                            Result = "Fizz"
                        },
                    new FizzBuzzRequest()
                        {
                            Check = x => x % 5 == 0,
                            Result = "Buzz"
                        },
                };

        public FizzBuzz()
        {

        }

        public FizzBuzz(List<FizzBuzzRequest> fizzBuzzRequests)
        {
            _fizzBuzzRequests = fizzBuzzRequests;
        }


        /// <summary>
        /// 
        /// Order of your FizzBuzzRequest is important. Which everyone hits first will return.
        /// </summary>
        public IEnumerable<string> Run()
        {
            long i = 0;

            while (true)
            {
                i++;
                var resultSent = false;

                foreach (var fizzBuzzRequest in _fizzBuzzRequests)
                {
                    if (fizzBuzzRequest.Check(i))
                    {
                        yield return fizzBuzzRequest.Result;
                        resultSent = true;
                    }
                }

                if (!resultSent)
                    yield return i.ToString();
            }
        }
    }

    public class FizzBuzzRequest
    {
        public Func<long, bool> Check { get; set; }
        public string Result { get; set; }
    }
}
