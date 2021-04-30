using System;
using Xunit;
using OTP_CDV;

namespace OTP_CDV_TEST
{
    public class CDV_UnitTest
    {
        [Fact]
        public void ShouldReturnValidCDV()
        {
            CDV_GEN cdv = new CDV_GEN();
            cdv.generateCDV("11727589-03933613-15579942");
            int expected = cdv.cdv % 10;
            Assert.Equals(expected, 0);
        }
    }
}
