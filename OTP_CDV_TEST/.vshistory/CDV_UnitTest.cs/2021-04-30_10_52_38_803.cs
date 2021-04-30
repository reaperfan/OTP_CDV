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
            cdv.generateCDV("11773322-1203809");

            Assert.Equal(5, cdv.cdv);
        }
    }
}
