using Xunit;

namespace BootcampFunctions.Test
{
    public class YearsAgoTest
    {
        [Fact]
        public void SeventeenYearsAgoTest()
        {
            var yearsAgo = new YearsAgo();
            Assert.Equal(17, yearsAgo.yearsAgo(2004));
        }
        [Fact]
        public void ThirtyTwoYearsAgoTest()
        {
            var yearsAgo = new YearsAgo();
            Assert.Equal(32, yearsAgo.yearsAgo(1989));
        }
        [Fact]
        public void TwerntySevenYearsAgoTest()
        {
            var yearsAgo = new YearsAgo();
            Assert.Equal(28, yearsAgo.yearsAgo(1993));
        }
    }

}
