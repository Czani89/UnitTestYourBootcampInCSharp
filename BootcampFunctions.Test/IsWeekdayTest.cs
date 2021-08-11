using Xunit;

namespace BootcampFunctions.Test
{
    public class IsWeekdayTest
    {
        [Fact]
        public void isSundayTest()
        {
            var isWeekday = new IsWeekday();
            Assert.False(isWeekday.isWeekday("Sunday"));

        }
        [Fact]
        public void isSaturdayaWeekdaTest()
        {
            var isWeekday = new IsWeekday();
            Assert.False(isWeekday.isWeekday("Saturday"));

        }
        [Fact]
        public void isMondayaWeekdayTest()
        {
            var isWeekday = new IsWeekday();
            Assert.True(isWeekday.isWeekday("Monday"));

        }
        [Fact]
        public void isWednesdayaWeekdayTest()
        {
            var isWeekday = new IsWeekday();
            Assert.True(isWeekday.isWeekday("Wednesday"));

        }
    }

}
