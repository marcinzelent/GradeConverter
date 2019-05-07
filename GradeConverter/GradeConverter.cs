using System;
using System.Collections.Generic;

namespace GradeConverter
{
    public static class GradeConverter
    {
        static String[,] conversionTable = {
            {"A", "12"},
            {"B", "10"},
            {"C", "7"},
            {"D", "4"},
            {"E", "2"},
            {"FX", "0"},
            {"F", "-2"}
        };

        public static String ConvertToEuropean(String grade)
        {
            String output = "";

            for (int i = 0; i < conversionTable.GetLength(0); i++)
            {
                if (grade == conversionTable[i,1])
                    output = conversionTable[i,0];
            }

            return output;
        }

        public static String ConvertToDanish(String grade)
        {
            String output = "";

            for (int i = 0; i < conversionTable.GetLength(0); i++)
            {
                if (grade == conversionTable[i,0])
                    output = conversionTable[i,1];
            }

            return output;
        }
    }
}
