//https://www.hackerrank.com/challenges/an-interesting-game-1/problem

using System;
using System.Collections.Generic;
using System.Linq;

namespace cs_hackerrank_gaming_array
{
    class Program
    {
        /*
           Dizideki en buyuk elemanin index i
        cift ise  BOB
        tek ise ANDY
         */
        public static string gamingArray(List<int> arr)
        {
            int max = int.MinValue;
            bool turn = true; // [true, bob] [false, andy]
            arr.ForEach(i =>
            {
                if (i > max)
                {
                    max = i;
                    turn = !turn;
                }
            });
            if (!turn)//count % 2 != 0
            {
                return "BOB";
            }
            else
            {
                return "ANDY";
            }
            //List<int> tempArr = arr.Except(arr.GetRange(arr.IndexOf(arr.Max()), (arr.Count() - arr.IndexOf(arr.Max())))).ToList();
            //if (tempArr.IndexOf(tempArr.Max()) % 2 == 0)
            //{
            //    return "BOB";
            //}
            //else
            //{
            //    return "ANDY";
            //}
        }

        static void Main(string[] args)
        {
            //string result;


            int g = Convert.ToInt32(Console.ReadLine().Trim()); // Tur sayisi
            for (int i = 0; i < g; i++)
            {
                int max = int.MinValue;
                bool turn = true; // [true, bob] [false, andy]
                List<int> arr = new List<int>();
                //Console.Write("Dizinin eleman sayisi: ");
                int n = Convert.ToInt32(Console.ReadLine().Trim()); // dizinin eleman sayisi
                for (int j = 0; j < n; j++) // eleman sayisi kadar diziye eleman girisi
                {


                    int a = Convert.ToInt32(Console.ReadLine().Trim());
                    arr.Add(a);
                    if (a > max)
                    {
                        max = a;
                        //count++;
                        turn = !turn;
                    }


                }
                string result;
                if (!turn)//count % 2 != 0
                {
                    result = "BOB";
                }
                else
                {
                    result = "ANDY";
                }
                //arr.Except(arr.GetRange(arr.IndexOf(arr.Max()), (arr.Count() - arr.IndexOf(arr.Max())))).ToList().ForEach(i => Console.WriteLine($"*{i}"));

                //Console.WriteLine(gamingArray(arr).ToString());

                //Console.WriteLine($"maks {max} indexi {arr.IndexOf(max)}");
                //if (turn)
                //{
                //    Console.WriteLine("BOB");
                //}
                //else
                //{
                //    Console.WriteLine("ANDY");
                //}
                //turn = true;
                /*  arr.Except(arr.GetRange(arr.IndexOf(arr.Max()), (arr.Count() - arr.IndexOf(arr.Max())))).ToList().ForEach(i => Console.WriteLine($"{i}"));

                  arr.GetRange(arr.IndexOf(arr.Max()), (arr.Count() - arr.IndexOf(arr.Max()))).ForEach(i => Console.WriteLine($"*{i}")); // Dizinin en buyuk elemandan sonrasini icerir.
                */



                //Console.WriteLine(result.ToString());
            }
            //Console.WriteLine("arr");
            //arr.ForEach(i => Console.Write($"{i},"));



        }

    }

}
