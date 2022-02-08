using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSumOfInterval
{
    public class Solution
    {

        /// <summary>
        /// 复杂度 O(K³)
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        /*
        public int[] FindMaxSumOfInterval(double[] val)
        {
            int leftIntervalLocation = -1, rightIntervalLocation = -1;
            double tempSumOfNumberValue, maxSumOfNumberValue = 0;
            int n = 0, f = 0;

            for (int i = 0; i < val.Length; i++)
            {
                for (int j = i; j < val.Length; j++)
                {
                    f++;
                    tempSumOfNumberValue = 0;

                    for (int k = i; k < j + 1; k++)
                    {
                        n++;
                        tempSumOfNumberValue += val[k];
                    }

                    if (tempSumOfNumberValue > maxSumOfNumberValue)
                    {
                        maxSumOfNumberValue = tempSumOfNumberValue;

                        leftIntervalLocation = i;
                        rightIntervalLocation = j;
                    }
                }
            }


            return new int[] { leftIntervalLocation, rightIntervalLocation, n, f };
        }
        */

        /// <summary>
        /// 复杂度 O(K²)
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public int[] FindMaxSumOfInterval(double[] val)
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            double[] intArray = new double[13] { 1.5, -12.3, 3.2, -5.5, 23.2, 3.2, -1.4, -12.2, 34.2, 5.4, -7.8, 1.1, -4.9 };

            Solution solution = new Solution();
            int[] ret = solution.FindMaxSumOfInterval(intArray);

            Console.WriteLine("总和最大的区间位置为{0}-{1},共计算{2}次", ret[0].ToString(), ret[1].ToString(), ret[2].ToString());

            Console.ReadLine();
        }
    }
}