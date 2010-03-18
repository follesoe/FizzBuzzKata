using NUnit.Framework;
using System;

namespace FizzBuzzKata.Test
{
    [TestFixture]
    public class FizzBuzzTest
    {
        private const string Buzz = "buzz";
        private const string Fizz = "fizz";
        private const string FizzBuzz = "fizzbuzz";

        [Test]
        public void Number_is_returned_if_not_multiple_of_3_or_5()
        {            
            Assert.AreEqual("1", _fizzBuzz.StringFor(1));
            Assert.AreEqual("2", _fizzBuzz.StringFor(2));
            Assert.AreEqual("4", _fizzBuzz.StringFor(4));
            Assert.AreEqual("7", _fizzBuzz.StringFor(7));
        }

        [Test]
        public void Returns_fizz_for_multiples_of_3()
        {
            Assert.AreEqual(Fizz, _fizzBuzz.StringFor(3));
            Assert.AreEqual(Fizz, _fizzBuzz.StringFor(6));
        }

        [Test]
        public void Returns_buzz_for_multiple_of_5()
        {
            Assert.AreEqual(Buzz, _fizzBuzz.StringFor(5));
            Assert.AreEqual(Buzz, _fizzBuzz.StringFor(10));
        }

        [Test]
        public void Returns_fizzbuzz_for_multiples_of_3_and_5()
        {
            Assert.AreEqual(FizzBuzz, _fizzBuzz.StringFor(15));
        }

        [Test]
        public void Throws_exception_for_value_less_than_one()
        {
            try
            {
                _fizzBuzz.StringFor(0);
                Assert.Fail();
            }
            catch (ArgumentOutOfRangeException x)
            {
                Assert.IsTrue(x.Message.StartsWith("Number must be greater than 0"));               
            }
        }

        [Test]
        public void Throws_exception_for_value_more_than_hundred()
        {
            try
            {
                _fizzBuzz.StringFor(101);
                Assert.Fail();
            }
            catch (ArgumentOutOfRangeException x)
            {
                Assert.IsTrue(x.Message.StartsWith("Number must be less than 101"));
            }
        }

        private FizzBuzz _fizzBuzz;

        [SetUp]
        public void Setup()
        {
            _fizzBuzz = new FizzBuzz();
        }
    }
}
