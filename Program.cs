using System;

namespace power
{
    class Program
    {
        public static int metodDouble1(int number, int exponent)
        {
            if (exponent == 0) 
                return 1;
            if (exponent % 2 == 0)
            {
                var num = metodDouble1(number, exponent / 2);
                return num * num;
            }
            else
            {
                return number * metodDouble1(number, exponent - 1);
            }
        }
        public static int metodDouble2(int number, int exponent)

        {
            if (exponent == 0)
                return 1;
            var result = 1;
            var tail = 1.0;
            while (exponent > 0)
            {
                if (exponent % 2 == 1)
                    tail *= number;
                result *= number;
                exponent /= 2;

            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(metodDouble1(3, 10));
            
        }
    }
}