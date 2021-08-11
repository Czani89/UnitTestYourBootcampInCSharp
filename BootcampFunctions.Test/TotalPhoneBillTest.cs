using System;
using Xunit;
using BootcampFunctions;

namespace BootcampFunctions.Test
{
    public class TotalPhoneBillTest
    {
        [Fact]
        public void StringTotalTest()
        {
            var totalPhoneBills = new TotalPhoneBill();
            Assert.Equal(4.70 , totalPhoneBills.Total("sms,call,sms,sms"));

        }
        [Fact]
        public void callTotalTest()
        {
            var totalPhoneBills = new TotalPhoneBill();
            Assert.Equal(2.75, totalPhoneBills.Total("call"));

        }
        [Fact]
        public void smsTotalTest()
        {
            var totalPhoneBills = new TotalPhoneBill();
            Assert.Equal(0.65, totalPhoneBills.Total("sms"));

        }
    }

}
