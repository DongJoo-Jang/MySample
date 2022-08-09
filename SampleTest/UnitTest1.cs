using System;
using Xunit;
using xUnitTestSample;

namespace SampleTest
{
    public class UnitTest1
    {
        [Fact]
        public void PrimeService_IsPrimeShould()
        {
            var primeService = new PrimeService();
            bool result = primeService.IsPrime(1);

            Assert.False(result, "1 should not be prime");

        }

        [Fact]
        public void CanAdd()
        {
            var calculator = new Calculator();

            int value1 = 1;
            int vlaue2 = 2;

            var result = calculator.Add(value1, vlaue2);

            Assert.Equal(3, result);
           

        }
    }
}
