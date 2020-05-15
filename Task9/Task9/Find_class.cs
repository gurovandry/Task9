using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    class Find_class
    {
        private static int One_number(int number)
        {
            int result = -1;
            int sqrt_num = Convert.ToInt32(Math.Truncate(Math.Sqrt(number)));
            bool is_simple = true;
            for (int i = 2; i <= sqrt_num; i++)
            {
                if (number % i == 0)
                {
                    is_simple = false;
                    break;
                }

            }
            if (is_simple)
            {
                result = number;
            }
            return result;
        }

        public static List<int> Intervals(int from_int, int to_int)
        {
            List<int> result_list = new List<int>();
            for (int i = from_int; i <= to_int; i++)
            {
                int result_int = One_number(i);
                if (result_int != -1)
                {
                    result_list.Add(i);
                }
            }
            return result_list;
        }
    }
}
