using Xunit;

namespace BootcampFunctions.Test
{
    public class GreetTest
    {
        [Fact]
        public void ShouldGreetLusandaCorrectly()
        {
            var greet = new Greet();
            Assert.Equal("Hello, Lusanda", greet.greet("Lusanda"));
        }

        [Fact]
        public void ShouldGreetCingaCorrectly()
        {
            var greet = new Greet();
            Assert.Equal("Hello, Cinga", greet.greet("Cinga"));
        }

        [Fact]
        public void ShouldGreetAndreCorrectly()
        {
            var greet = new Greet();
            Assert.Equal("Hello, Andre", greet.greet("Andre"));
        }
    }

}
