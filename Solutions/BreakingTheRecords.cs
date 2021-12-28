using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_hackerrank
{
    internal class Program
    {
        class Result
        {

            /*
             * Complete the 'breakingRecords' function below.
             *
             * The function is expected to return an INTEGER_ARRAY.
             * The function accepts INTEGER_ARRAY scores as parameter.
             */

            public static List<int> breakingRecords(List<int> scores)
            {
                List<int> result = new List<int>();
                int max = int.MinValue;
                int min = int.MaxValue;
                int maxCount = -1;
                int minCount = -1;

                scores.ForEach(x =>
                {
                    if (x > max)
                    {
                        max = x;
                        maxCount++;
                    }
                    if (x < min)
                    {
                        min = x;
                        minCount++;
                    }
                });
                //Console.WriteLine("MAX : " +max);
                //Console.WriteLine("MAX COUNT : " +maxCount);
                //Console.WriteLine("MIN : " +min);
                //Console.WriteLine("MIN COUNT : " + minCount);

                result.Add(maxCount);
                result.Add(minCount);
                return result;
            }
        }

        class Solution
        {
            public static void Main(string[] args)
            {

                int n = Convert.ToInt32(Console.ReadLine().Trim());

                List<int> scores = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(scoresTemp => Convert.ToInt32(scoresTemp)).ToList();

                List<int> result = Result.breakingRecords(scores);

                Console.WriteLine(String.Join(" ", result));

                Console.ReadLine();
            }
        }


    }
}
