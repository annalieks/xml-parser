using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace XMLParser
{
    static class Utils
    {
        static public Quality ParseToQuality(string value)
        {
            bool success = Enum.TryParse(value, true, out Quality quality);
            return success ? quality : Quality.Unknown;
        }

        static public Quality ParseToQuality(XAttribute attribute)
        {
            return attribute == null 
                ? Quality.Unknown 
                : ParseToQuality(attribute.Value);
        }

        static public int? ParseToInt(string value)
        {
            bool success = Int32.TryParse(value, out int result);
            if (success) return result;
            else return null;
        }

        static public int? ParseToInt(XAttribute attribute)
        {
            return attribute == null ? null : ParseToInt(attribute.Value);
        }
    }
}
