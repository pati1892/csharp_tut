using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntToString
{
    class Program
    {

        static string IntToStringLeftToRight(int value)
        {
            StringBuilder sb = new StringBuilder();

            int result = 10;
            int div;
            for (div = 1; result > 9; div *= 10)
            {
                result = value / div;
            }
            div /= 10;

            for (; div > 1; div /= 10)
            {
                sb.Append(value / div);
                value %= div;
            }
            sb.Append(value);
            return sb.ToString();
        }

        static string IntToStringRightToLeft(int value)
        {
            StringBuilder sb = new StringBuilder();
            for(; value != 0 ; )
            {
                int number = value % 10;
                value /= 10;
                sb.Append(number);
            }
            char[] array = sb.ToString().ToCharArray();
            Array.Reverse(array);
            return string.Concat(array);
        }


        static void Main(string[] args)
        {
            int value = 123456;
            Console.WriteLine(IntToStringLeftToRight(value));
            Console.WriteLine(IntToStringRightToLeft(value));
        }
    }
}
