using System;
using System.Collections.Generic;
using System.Linq;

namespace cs_hackerrank
{
    class Result
    {
        public static int diagonalDifference(List<List<int>> arr)
        {

            int temp = arr.Count();
            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < arr.Count(); i++)
            {
                leftSum += arr[i][temp - 1];
                rightSum += arr[i][i];
                temp--;
            }


            return Math.Abs(leftSum - rightSum);
        }
    }






    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            int result = Result.diagonalDifference(arr);

        }
    }
}
