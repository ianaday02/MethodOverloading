using System;

namespace MethodOverloading
{
    internal class Program
    {
        int Add(int x, int y)
        {
            return (x + y);
        }
        decimal Add(decimal x, decimal y)
        {
            return (x + y);
        }

       string Add(int x, int y, bool isTrue)
        {
            if (isTrue == true)
            {
                if (x + y == 1)
                {
                    return ("1 dollar");
                }
                else return ($"{x + y} dollars");
            }
            else
            {
                return ($"{x + y}");
            }
        }

        static void Main(string[] args)
        {

        }
    }
}