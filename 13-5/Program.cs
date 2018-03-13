using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] fibonatis = new int[10];
            fibonatis[0] = 1;
            fibonatis[1] = 1;
            fibonatis[2] = 0;

            for (int i = 2; i < fibonatis.Length; i++)
            {
                fibonatis[i] = fibonatis[i - 1] + fibonatis[i - 2];

            }

        }
    }
}
