using Xunit;

namespace BootcampFunctions.Test
{
    public class CountAllPaarlTest
    {
        [Fact]
        public void count3PaarlTest()
        {
            var countAllPaarl = new  CountAllPaarl();
            Assert.Equal(3, countAllPaarl.countAllPaarl("CJ 123, CJ 233, CY 557, CJ 887"));
        }
        [Fact]
        public void count4PaarlTest()
        {
            var countAllPaarl = new CountAllPaarl();
            Assert.Equal(4, countAllPaarl.countAllPaarl("CJ 123, CJ 233, CY 557, CJ 887, CJ 258"));
        }
    }

}
