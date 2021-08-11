using System;
using Xunit;
using BootcampFunctions;

namespace BootcampFunctions.Test
{
    public class TotalPhoneBillTest
    {
        [Fact]
        public void StringTotalTest()
        {
            var totalPhoneBills = new TotalPhoneBill();
            Assert.Equal(4.70 , totalPhoneBills.Total("sms,call,sms,sms"));

        }
    }
    public class GreetTest
    {
        [Fact]
        public void GreetNameTest()
        {
            var greet = new Greet();
            Assert.Equal("Hello, Lusanda", greet.greet("Lusanda"));
        }


    }
    public class CarsFromBellvilleTest
    {
        [Fact]
        public void IsFromBellvilleTest()
        {
            var isFromBellville = new IsFromBellville();
            Assert.True(isFromBellville.isFromBellville("CY"));

        }

    }
    public class RegistrationCheckTest
    {
        [Fact]
        public void RegCheckTest()
        {
            var regCheck = new RegCheck();
            Assert.True(regCheck.regCheck("CY 123", "CY"));
        }
    }
    public class countRegistrationNumberTest
    {
        [Fact]
        public void countRegNumber()
        {
            var regCount = new CountRegNumber();
            Assert.Equal(7, regCount.countRegNumber("CA 182736,CY 523519, CA 42665, AA 12 RT GP, CA 182736,CY 523519,CJ 812328"));
        }
    }
    public class IsWeekdayTest
    {
        [Fact]
        public void isWeekdayTest()
        {
            var isWeekday = new IsWeekday();
            Assert.False(isWeekday.isWeekday("Sunday"));

        }
    }
    public class YearsAgoTest
    {
        [Fact]
        public void yearsAgoTest()
        {
            var yearsAgo = new YearsAgo();
            // Console.WriteLine(yearsAgo);
            Assert.Equal(17, yearsAgo.yearsAgo(2004));
        }
    }
    public class CountAllPaarlTest
    {
        [Fact]
        public void countAllPaarlTest()
        {
            var countAllPaarl = new  CountAllPaarl();
            Assert.Equal(3, countAllPaarl.countAllPaarl("CJ 123, CJ 233, CY 557, CJ 887"));
        }
    }
    public class CountAllFromTownTest
    {
        [Fact]
        public void countAllFromTownTest()
        {
            var countAllFromTown = new CountAllFromTown();
            Assert.Equal(3, countAllFromTown.countAllFromTown("CA", "CA 123, CA 555, CF 777, CY 155, CA 12345"));
        }
    }
    public class TransportFeeTest
    {
        [Fact]
        public void transportFeeTest()
        {
            var transportFee = new TransportFee();
            Assert.Equal("free", transportFee.transportFee("nightshift"));
        }
    }
    public class FromWhereTest
    {
        [Fact]
        public void fromWhereTest()
        {
            var fromWhere = new FromWhere();
            Assert.Equal("Bellville", fromWhere.fromWhere("CY"));
        }
    }

}
