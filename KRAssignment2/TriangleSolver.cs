using System;
using System.Text.RegularExpressions;

namespace KRAssignment2
{
    public class TriangleSolver
    {
        public TriangleSolver()
        {
        }

        public static string Analize(string a, string b, string c)
        {

            Match mA = Regex.Match(a, @"^\d$");
            Match mB = Regex.Match(b, @"^\d$");
            Match mC = Regex.Match(c, @"^\d$");

            if (mA.Success && mB.Success && mC.Success)
            {
                if (Int32.Parse(a) < 0 || Int32.Parse(b) < 0 || Int32.Parse(c) < 0)
                {
                    return "You cannot form a triangle, with any value minor to zero";
                }
                else if (Int32.Parse(a) == 0 || Int32.Parse(b) == 0 || Int32.Parse(c) == 0)
                {
                    return "You cannot form a triangle, with any value equal to zero";
                }
                else
                {
                    if (a == b && b == c)
                    {
                        return "Equilateral triangle";
                    }
                    else if (a == b || a == c || b == c)
                    {
                        return "Isosceles triangle";
                    }
                    else
                    {
                        return "Scalene triangle";
                    }
                }
            }
            else
            {
                //Missing one side of the triangle, so cannot form a triangle
                return "";
            }
        }
    }
}
