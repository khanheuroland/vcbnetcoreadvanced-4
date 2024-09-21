using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using vcbmain.Services;

namespace vcbtest.Services
{
    public class FizzBuzzTest
    {
        private FizzBuzz fizzBuzz;

        public FizzBuzzTest()
        {
            this.fizzBuzz = new FizzBuzz();
        }

        [Theory]
        [InlineData(2, "1,2")]
        [InlineData(3, "1,2,fizz")]
        [InlineData(5, "1,2,fizz,4,buzz")]
        [InlineData(15, "1,2,fizz,4,buzz,fizz,7,8,fizz,buzz,11,fizz,13,14,fizzbuzz")]
        public void Should_return_with_fizz_buzz(int number, string exected)
        {
            //Act
            String actual = this.fizzBuzz.Get(number);

            //Assert
            Assert.Equal(exected, actual);
        }

        [Theory]
        [MemberData(nameof(GetFizBuzzData))]
        public void Should_return_with_fizz_buzz2(int number, string exected)
        {
            //Act
            String actual = this.fizzBuzz.Get(number);

            //Assert
            Assert.Equal(exected, actual);
        }

        public static List<Object[]> GetFizBuzzData => new List<object[]>
        {
            new object[] { 2, "1,2"},
            new object[] { 3, "1,2,fizz"},
            new object[] { 5, "1,2,fizz,4,buzz"},
            new object[] {15, "1,2,fizz,4,buzz,fizz,7,8,fizz,buzz,11,fizz,13,14,fizzbuzz"}
        };
    }
}