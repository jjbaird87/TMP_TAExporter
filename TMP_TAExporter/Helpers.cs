using System;

namespace TMP_TAExporter
{
    public static class Helpers
    {
        public static DateTime GetLowestDt(DateTime dateTimeCurrent)
        {
            return new DateTime(
                dateTimeCurrent.Year,
                dateTimeCurrent.Month,
                dateTimeCurrent.Day,
                0,
                0,
                0);
        }

        public static DateTime GetHighestDt(DateTime dateTimeCurrent)
        {
            return new DateTime(
                dateTimeCurrent.Year,
                dateTimeCurrent.Month,
                dateTimeCurrent.Day,
                23,
                59,
                59);
        }
    }
}