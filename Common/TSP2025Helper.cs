namespace TSP2025.Common
{
    public static class TSP2025Helper
    {
        public static string EnvironmentNewLines(int count)
        {
            string retVal = Environment.NewLine;
            for (int i = 1; i < count; i++)
            {
                retVal += Environment.NewLine;
            }
            return retVal;
        }
    }
}
