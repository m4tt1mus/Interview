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
        //[Test]
        //public void BasicNumberTest()
        //{
        //    var result = FizzBuzz.Run().Take(2).ToArray();

        //    Assert.AreEqual("1", result[0]);
        //    Assert.AreEqual("2", result[1]);
        //}

        [Test]
        public void TestFizz()
        {
            var fb = new FizzBuzz();
            var result = fb.Run().Take(3).Last();

            Assert.AreEqual("Fizz", result);
        }

        //[Test]
        //public void TestBuzz()
        //{
        //    var result = FizzBuzz.Run().Take(5).Last();

        //    Assert.AreEqual("Buzz", result);
        //}

        //[Test]
        //public void TestFizzBuzz()
        //{
        //    var result = FizzBuzz.Run().Take(15).Last();

        //    Assert.AreEqual("FizzBuzz", result);
        //}

        //[Test]
        //public void SkipOneTakeTwo()
        //{
        //    var result = FizzBuzz.Run().Skip(1).Take(2).ToArray();

        //    Assert.AreEqual("2", result[0]);
        //    Assert.AreEqual("Fizz", result[1]);
        //}

        //[Test]
        //public void OneBillionTest()
        //{
        //    var result = FizzBuzz.Run().Take(1000000000).Last();

        //    Assert.AreEqual("Buzz", result);
        //}
    }
}
