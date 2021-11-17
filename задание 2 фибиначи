using System;

namespace ConsoleApp11
{
    class Program
    {
        static int metodFiban2(int i)
        {
            int result = 0;
            int b = 1;
            int tmp;

            for (int j = 0; j < i; j++)
            {
                tmp = result;
                result = b;
                b += tmp;
            }

            return result;
        }
        public static int metodFiban(int i)
        {
            int number1, number2;
            if (i <= 2)
                return 1;
            else
            {
                number1 = metodFiban(i - 1);
                number2 = metodFiban(i - 2);
            }
            return number1 + number2;
            
            

        }
        static void Main(string[] args)
        {
            Console.WriteLine(metodFiban2(100));
        }
    }
}
