using System.Globalization;

namespace WeihnachtsbaumBlazor.Extensions
{
    public static class ToStringExtension
    {

        public static string GetCssValue(this decimal value, string unit = "px") => value.ToString("0.00", CultureInfo.InvariantCulture) + unit;
    }
}
