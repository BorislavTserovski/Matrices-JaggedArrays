using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HalfSumElement
{
    class Program
    {
        static void Main(string[] args)


        {
            var n = int.Parse(Console.ReadLine());
            var max = 0;
            int curentNumber = 0;
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                curentNumber = int.Parse(Console.ReadLine());
                sum = sum + curentNumber;

                if (curentNumber > max)
                {
                    max = curentNumber;
                }
            }

            if (sum - max == max)
            {
                Console.WriteLine("Yes Sum = " + (sum-max));
            }
            else
            {
                Console.WriteLine("No, diff = {0}", Math.Abs(max - (sum - max)));
            }

        }
    }
}