namespace BootcampFunctions
{
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
}
