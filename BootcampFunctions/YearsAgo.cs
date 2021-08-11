using System;

namespace BootcampFunctions
{
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
}
