using System;
using System.Collections.Generic;

namespace BootcampFunctions
{
    public class TotalPhoneBill
    {
        public TotalPhoneBill()
        {
            payCall = new List<string>();
            paySms = new List<string>();
        }
        public double Total(string param)
        {

            string[] splitParam = param.Trim().Split(",");
            for (var i = 0; i < splitParam.Length; i++)
            {
                if (splitParam[i].StartsWith("c"))
                {
                    payCall.Add(splitParam[i]);
                };
                if (splitParam[i].StartsWith("s"))
                {
                    paySms.Add(splitParam[i]);
                }
            }
            double callTotals = payCall.Count * 2.75 + paySms.Count * 0.65;
            var callTotal = Math.Round(callTotals, 1, MidpointRounding.ToZero);
            return callTotal;
            // return the result.
        }
        private List<string> payCall;
        private List<string> paySms;
    }

    public class Greet
    {
        public string greet(string name)
        {
            return $"Hello, {name}";
        }
    }
    public class IsFromBellville
    {
        public bool isFromBellville(string bellville)
        {
            return bellville.StartsWith("CY");
        }

    }
    public class RegCheck
    {
        public bool regCheck(string location, string reg)
        {
            return location.Contains(reg);
        }

    }
    public class CountRegNumber
    {
        public int countRegNumber(string reg)
        {
            return reg.Split(',').Length;
        }
    }
    public class IsWeekday
    {
        public bool isWeekday(string day)
        {
            return (!day.StartsWith("S"));
        }
    }
    public class YearsAgo
    {
        public int yearsAgo(int year)
        {
            var currentDate = DateTime.Now;
            var currentYear = currentDate.Year;
            // Console.WriteLine(currentYear);
            return currentYear - year;
        }
    }
    public class CountAllPaarl
    {
        public int countAllPaarl(string regN)
        {
            var regNumber = regN.Split(",");
            var regNumCounter = 0;

            for (var i = 0; i < regNumber.Length; i++)
            {
                var regNum = regNumber[i].Trim();
                if (regNum.StartsWith("CJ"))
                {
                    regNumCounter++;
                }
            }
            return regNumCounter;
        }
    }
    public class CountAllFromTown
    {
        public CountAllFromTown()
        {
            allReg = new List<string>();
        }

        public int countAllFromTown(string regNumStr, string regNum)
        {
            var regN = regNum.Split(",");
            var regCount = 0;
            for (var i = 0; i < regN.Length; i++)
            {
                var trimmedRegN = regN[i].Trim();

                if (trimmedRegN.StartsWith(regNumStr))
                {
                    allReg.Add(trimmedRegN);
                    regCount++;
                }
            }
            return regCount;
        }
        private List<string> allReg;
    }
    public class TransportFee
    {
        public string transportFee(string timeOfDay)
        {
            switch (timeOfDay)
            {
                case "morning":
                    return "R20";
                case "afternoon":
                    return "R10";
                case "nightshift":
                    return "free";
            }
            return "Enter Correct Shift";
        }
    }
public class FromWhere
    {
        public string fromWhere(string town)
        {
            switch (town)
            {
                case "CY":
                    return "Bellville";
                case "CJ":
                    return "Paarl";
                case "CA":
                    return "Cape Town";
            }

            return "Some other place!";
        }
    }
}
