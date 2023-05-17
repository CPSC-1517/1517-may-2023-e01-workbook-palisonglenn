using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsReview
{
    public static class Utilities
    {
        // Static classes are not instantiated by the user
        // Static class items are referenced using classname.xxx
        // Methods within the class have the keyword static in their signature
        // Static classes are shared between all outside users at the same time
        // DO NOT store data within a static class
        // Place generic reusable methods with a static class

        // Example: 
        public static bool IsZeroOrPositive(double value)
        {
            bool valid = true;
            if (value < 0.0)
            {
                valid = false;
            }
            return valid;
        }
        public static bool IsZeroOrPositive(int value)
        {
            bool valid = true;
            if (value < 0)
            {
                valid = false;
            }
            return valid;
        }

        public static bool IsZeroOrPositive(decimal value)
        {
            bool valid = true;
            if (value < 0.0m)
            {
                valid = false;
            }
            return valid;
        }


    }
}
