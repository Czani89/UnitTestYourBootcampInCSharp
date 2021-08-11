using Xunit;

namespace BootcampFunctions.Test
{
    public class RegistrationCheckTest
    {
        [Fact]
        public void CYRegCheckTest()
        {
            var regCheck = new RegCheck();
            Assert.True(regCheck.regCheck("CY 123", "CY"));
        }
        [Fact]
        public void CKRegCheckTest()
        {
            var regCheck = new RegCheck();
            Assert.False(regCheck.regCheck("CY 123", "CK"));
        }
        [Fact]
        public void CJRegCheckTest()
        {
            var regCheck = new RegCheck();
            Assert.True(regCheck.regCheck("CJ 123", "CJ"));
        }
    }

}
