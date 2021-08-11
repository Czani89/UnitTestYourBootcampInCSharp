using Xunit;

namespace BootcampFunctions.Test
{
    public class CountAllFromTownTest
    {
        [Fact]
        public void count3FromTownTest()
        {
            var countAllFromTown = new CountAllFromTown();
            Assert.Equal(3, countAllFromTown.countAllFromTown("CA", "CA 123, CA 555, CF 777, CY 155, CA 12345"));
        }
        [Fact]
        public void count1FromTownTest()
        {
            var countAllFromTown = new CountAllFromTown();
            Assert.Equal(1, countAllFromTown.countAllFromTown("CA", "CY 123, CJ 555, CF 777, CY 155, CA 12345"));
        }
    }

}
