using System;
namespace VogCodeChallenge.API.Misc
{
    public static class TESTModule
    {
        public static object Module(object testObject)
        {
            double diff_tolerence = 1.0 * 0.0001; //0.01% of compare value
            switch (testObject)
            {
                case 1:
                case 2:
                    return doubler((int)testObject);
                case int value when value >= 3:
                    return tripler(value);
                case float floatValue when Math.Abs(floatValue - 1.0f) <= diff_tolerence: // Changed the comparison of floating point numbers because of precision difference
                    return leveler(floatValue);
                default:
                    return testObject;
            }

            int doubler(int amount) => amount * 2;
            int tripler(int amount) => amount * 3;
            double leveler(double amount) => amount - 0.1f * 10f;
        }
    }

}
