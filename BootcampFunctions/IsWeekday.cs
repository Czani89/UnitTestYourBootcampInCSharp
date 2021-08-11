namespace BootcampFunctions
{
    public class IsWeekday
    {
        public bool isWeekday(string day)
        {
            return (!day.StartsWith("S"));
        }
    }
}
