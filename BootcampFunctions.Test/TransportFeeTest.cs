using Xunit;

namespace BootcampFunctions.Test
{
    public class nightshiftTransportFeeTest
    {
        [Fact]
        public void transportFeeTest()
        {
            var transportFee = new TransportFee();
            Assert.Equal("free", transportFee.transportFee("nightshift"));
        }
    }
    public class morningTransportFeeTest
    {
        [Fact]
        public void transportFeeTest()
        {
            var transportFee = new TransportFee();
            Assert.Equal("R20", transportFee.transportFee("morning"));
        }
    }
    public class afternoonTransportFeeTest
    {
        [Fact]
        public void transportFeeTest()
        {
            var transportFee = new TransportFee();
            Assert.Equal("R10", transportFee.transportFee("afternoon"));
        }
    }
    public class dayTransportFeeTest
    {
        [Fact]
        public void transportFeeTest()
        {
            var transportFee = new TransportFee();
            Assert.Equal("Enter Correct Shift", transportFee.transportFee("day"));
        }
    }

}
