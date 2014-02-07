using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Util;

namespace Interview.Tests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        public void BasicNumberTest()
        {
            var result = FizzBuzz.Run().Take(2).ToArray();

            Assert.AreEqual("1", result[0]);
            Assert.AreEqual("2", result[1]);
        }

        //[Test]
        //public void TestFizz()
        //{
        //    var fb = new Program();

        //    var result = Program.Run(1, 3).ToArray().Last();

        //    Assert.AreEqual("Fizz", result);
        //}

        //[Test]
        //public void TestBuzz()
        //{
        //    var result = Program.Run(1, 5).ToArray().Last();

        //    Assert.AreEqual("Buzz", result);
        //}

        //[Test]
        //public void TestFizzBuzz()
        //{
        //    var result = Program.Run(1, 15).ToArray().Last();

        //    Assert.AreEqual("FizzBuzz", result);
        //}

        //[Test]
        //public void TestLowerStartNumberThenEndNumber()
        //{
        //    var result = Program.Run(12, 1);

        //    Assert.IsEmpty(result);
        //}
    }
}
