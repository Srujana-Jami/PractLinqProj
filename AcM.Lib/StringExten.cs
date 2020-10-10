using System;
using System.Globalization;
using System.Threading;

namespace AcM.Lib
{
    public static class StringExten
    {
        public static string ConvertToTitleCase(this string source)
        {
            CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;
            return textInfo.ToTitleCase(source);
        }
    }
}
