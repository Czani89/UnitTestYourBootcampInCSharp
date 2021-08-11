using Xunit;

namespace BootcampFunctions.Test
{
    public class FromWhereTest
    {
        [Fact]
        public void fromBellvilleTest()
        {
            var fromWhere = new FromWhere();
            Assert.Equal("Bellville", fromWhere.fromWhere("CY"));
        }
        [Fact]
        public void fromCapeTownTest()
        {
            var fromWhere = new FromWhere();
            Assert.Equal("Cape Town", fromWhere.fromWhere("CA"));
        }
        [Fact]
        public void fromPaarlTest()
        {
            var fromWhere = new FromWhere();
            Assert.Equal("Paarl", fromWhere.fromWhere("CJ"));
        }
        [Fact]
        public void fromOtherPlaceTest()
        {
            var fromWhere = new FromWhere();
            Assert.Equal("Some other place!", fromWhere.fromWhere("CD"));
        }
    }

}
