using System;
using System.ComponentModel;
using ExcelDna.Integration;

namespace ExcelDna.CustomAddin
{
    // TODO: Remove these functions - they're jsut here for testing...
    public class MyFunctions
    {
        [ExcelFunction(Description = "A useful test function that adds two numbers, and returns the product.")]
        public static double AddThem(
            [ExcelArgument(Name = "Augend", Description = "is the first number, to which will be multiplied")] double v1,
            [ExcelArgument(Name = "Addend", Description = "is the second number that will be multiplied")]     double v2)
        {
            return v1 + v2;
        }

        [Description("Test function for the amazing Excel-DNA IntelliSense feature")]
        public static string jDummyFunc()
        {
            return "Howzit !";
        }

    }
}