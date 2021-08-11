using Xunit;

namespace BootcampFunctions.Test
{
    public class countRegistrationNumberTest
    {
        [Fact]
        public void count7RegNumber()
        {
            var regCount = new CountRegNumber();
            Assert.Equal(7, regCount.countRegNumber("CA 182736,CY 523519, CA 42665, AA 12 RT GP, CA 182736,CY 523519,CJ 812328"));
        }
        [Fact]
        public void count1RegNumber()
        {
            var regCount = new CountRegNumber();
            Assert.Equal(1, regCount.countRegNumber("CA 1258"));
        }
    }

}
