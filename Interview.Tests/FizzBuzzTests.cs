using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using FizzBuzz;

namespace Interview.Tests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        public void BasicNumberTest()
        {
            var fb = new Program();

            var result = fb.Run(1, 2).ToArray();

            Assert.AreEqual("1", result[0]);
            Assert.AreEqual("2", result[1]);
        }

        [Test]
        public void TestFizz()
        {
            var fb = new Program();

            var result = fb.Run(1, 3).ToArray().Last();

            Assert.AreEqual("Fizz", result);
        }

        [Test]
        public void TestBuzz()
        {
            var fb = new Program();

            var result = fb.Run(1, 5).ToArray().Last();

            Assert.AreEqual("Buzz", result);
        }

        [Test]
        public void TestFizzBuzz()
        {
            var fb = new Program();

            var result = fb.Run(1, 15).ToArray().Last();

            Assert.AreEqual("FizzBuzz", result);
        }

        [Test]
        public void TestLowerStartNumberThenEndNumber()
        {
            var fb = new Program();

            var result = fb.Run(12, 1);

            Assert.IsEmpty(result);
        }

        [Test]
        public void OneBillionRangeTest()
        {
            var fb = new Program();

            var result = fb.Run(1, 1000000001);

            Assert.AreSame(1000000001, result.Count());
        }
    }
}
