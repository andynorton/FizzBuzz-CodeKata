using System;
using NUnit.Framework;
using FizzBuzz_CodeKata;


namespace FizzBuzz_CodeKata.Test
{
    [TestFixture]
    public class FizzBuzzTest
    {
        private FizzBuzz fizzBuzz;

        [SetUp]
        public void Setup()
        {
            fizzBuzz = new FizzBuzz();
        }

        [Test]
        public void FizzBuzz_NumberNotMultipleOf3Or5_Return1()
        {
            Assert.That(fizzBuzz.DoFizzBuzz(1), Is.EqualTo("1"));
        }
        
        [Test]
        public void FizzBuzz_MultipleOf3_ReturnsFizz()
        {
            Assert.That(fizzBuzz.DoFizzBuzz(3), Is.EqualTo("Fizz"));
        }

        [Test]
        public void FizzBuzz_MultipleOf5_ReturnsBuzz()
        {
            Assert.That(fizzBuzz.DoFizzBuzz(5), Is.EqualTo("Buzz"));
        }

        [Test]
        public void FizzBuzz_MultipleOf3And5_ReturnsFizzBuzz()
        {
            Assert.That(fizzBuzz.DoFizzBuzz(15), Is.EqualTo("FizzBuzz"));
        }
    }
}
