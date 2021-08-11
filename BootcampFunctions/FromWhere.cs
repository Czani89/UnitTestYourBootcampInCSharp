namespace BootcampFunctions
{
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
