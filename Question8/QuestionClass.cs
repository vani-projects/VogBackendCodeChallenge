using System;
using System.Collections.Generic;

namespace Question8
{
    public static class QuestionClass
    {
        static List<string> NamesList = new List<string>()
        {
            "Jimmy",
            "jeffrey"
        };

        public static void TestQuestion()
        {
            NamesList.ForEach(x => Console.WriteLine(x));
        }
    }

}
