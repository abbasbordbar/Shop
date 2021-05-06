using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.ExtensionMethods
{
    public static class RatingEx
    {
        public static string Getrating(int value)
        {
            if (value > 75)
                return "عالی";
            if (value > 50)
                return "خوب";
            if (value > 25)
                return "معمولی";
            return "بد";

        }
    }
}
