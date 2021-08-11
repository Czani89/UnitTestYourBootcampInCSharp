namespace BootcampFunctions
{
    public class CountRegNumber
    {
        public int countRegNumber(string reg)
        {
            return reg.Split(',').Length;
        }
    }
}
