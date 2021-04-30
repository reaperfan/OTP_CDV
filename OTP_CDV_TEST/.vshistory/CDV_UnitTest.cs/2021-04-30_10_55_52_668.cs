using System;
using Xunit;
using OTP_CDV;

namespace OTP_CDV_TEST
{
    public class CDV_UnitTest
    {
        [Fact]
        public void ShouldReturnTwo()
        {
            CDV_GEN cdv = new CDV_GEN();
            cdv.generateCDV("11727589-03933613-1557994");
            int expected = 2;
            Assert.Equal(expected, cdv.cdv);
        }

        [Fact]
        public void ShouldReturnEight()
        {
            CDV_GEN cdv = new CDV_GEN();
            cdv.generateCDV("11744395-56848688-2679773");
            int expected = 8;
            Assert.Equal(expected, cdv.cdv);
        }
        [Fact]
        public void ShouldReturnEight()
        {
            CDV_GEN cdv = new CDV_GEN();
            cdv.generateCDV("11773322-1203809");
            int expected = 5;
            Assert.Equal(expected, cdv.cdv);
        }
    }
}
