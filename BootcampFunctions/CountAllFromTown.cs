using System.Collections.Generic;

namespace BootcampFunctions
{
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
}
