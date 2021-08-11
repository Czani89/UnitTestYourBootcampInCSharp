using Xunit;

namespace BootcampFunctions.Test
{
    public class CarsFromBellvilleTest
    {
        [Fact]
        public void IsFromBellvilleTest()
        {
            var isFromBellville = new IsFromBellville();
            Assert.True(isFromBellville.isFromBellville("CY"));

        }
        [Fact]
        public void IsNotFromBellvilleTest()
        {
            var isFromBellville = new IsFromBellville();
            Assert.False(isFromBellville.isFromBellville("CJ"));

        }

    }

}
