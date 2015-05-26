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
        public void Show_number_if_not_multiple_of_3_or_5()
        {
            Assert.That(fizzBuzz.DoFizzBuzz(1), Is.EqualTo("1"));
        }
        
        [Test]
        public void Show_fizz_if_multiple_of_3()
        {
            Assert.That(fizzBuzz.DoFizzBuzz(3), Is.EqualTo("Fizz"));
        }

        [Test]
        public void Show_buzz_if_multiple_of_5()
        {
            Assert.That(fizzBuzz.DoFizzBuzz(5), Is.EqualTo("Buzz"));
        }

        [Test]
        public void Show_fizzbuzz_if_multiple_of_both_3_and_5()
        {
            Assert.That(fizzBuzz.DoFizzBuzz(15), Is.EqualTo("FizzBuzz"));
        }
    }
}
