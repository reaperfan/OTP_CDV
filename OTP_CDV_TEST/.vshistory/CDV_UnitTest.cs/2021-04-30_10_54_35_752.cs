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
            Assert.Equal(expected, 0);
        }
    }
}
