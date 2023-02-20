/* Deep Magrodia
   Dr Yulia Kumar 
   Tech 4982 - 01
    */

namespace MaxNumberLibrary;

public class MaxFinder
{
    public static double FindMax(double num1, double num2)
    {
        return Math.Max(num1, num2);
    }

    public static double FindMax(double num1, double num2, double num3)
    {
        return Math.Max(Math.Max(num1, num2), num3);
    }


}


