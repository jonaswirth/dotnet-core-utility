using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_core_utility
{
    public static class IntExtensions
    {
        public static bool IsEven(this int value)
        {
            return (value % 2 == 0);
        }

        public static bool IsTheAnswerToLifeTheUniverseAndEverything(this int value)
        {
            return (value == 42);
        }
    }
}
