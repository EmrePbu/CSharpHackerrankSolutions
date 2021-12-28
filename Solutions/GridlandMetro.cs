using System;
using System.Collections.Generic;
using System.Linq;

namespace cs_hackerrank
{
    class Result
    {
        /*
		4 4 3
		2 2 3
		3 1 4
		4 4 4
		 */

        public static long gridlandMetro(int n, int m, int k, List<List<int>> track)
        {


            if (k == 0)
            {
                return n * m;
            }

            //track = track.OrderBy(i => i[0]).ThenBy(i => i[1]).ThenBy(i => i[2]).ToList();

            //Console.WriteLine("''''''");
            //track.ForEach(i =>
            //{
            //    i.ForEach(j =>
            //    {
            //        Console.WriteLine(j);
            //    });
            //});
            //Console.WriteLine("''''''");


            //track = track.OrderBy(d => d[0]).ToList();
            // c_2 - c_1
            long sum = track[0][2] - track[0][1] + 1;
            for (int i = 1; i < k; i++)
            {
                int r = track[i][0];
                int i_c_1 = track[i][1];
                int i_c_2 = track[i][2];

                if (r == track[i - 1][0] && (i_c_1 <= track[i - 1][2])) // kume islemi
                {
                    if (i_c_2 >= track[i - 1][2])
                    {
                        sum += i_c_2 - track[i - 1][2];
                    }
                    else
                    {
                        track[i][2] = track[i - 1][2];
                    }
                }
                else
                {
                    sum += i_c_2 - i_c_1 + 1;
                }

            }


            return (long)n * m - sum;




            #region MyRegion
            //long r = -1;
            //long c_1 = 0;
            //long c_2 = -1;
            //long sum = 0;
            //Console.WriteLine(track[k-1][0]);
            //Console.WriteLine(k);
            //for (int i = 0; i < k; i++)
            //{
            //Console.WriteLine(_c_2 > track[i - 1]);
            //Console.WriteLine("_r:{0}, track[i - 1]:{1}, _c_2:{2}", _r, track[i - 1], _c_2);
            //Console.WriteLine("r, _r  {0} != {1}", r, _r);
            //Console.WriteLine("track[i - 1], c_2  {0} > {1}", track[i - 1], c_2);
            //Console.WriteLine("_c_2:{0}", _c_2);
            //if ((r != _r) || (track[i - 1] > c_2))
            //{
            //sum -= ((c_2 - c_1) + 1);
            //Console.WriteLine("sum: {0}",(c_2- c_1)+1);
            //    r = _r;
            //    c_1 = track[i - 1];
            //    c_2 = _c_2;
            //}
            //else if (_c_2 > c_2)
            //    c_2 = _c_2;
            //else
            //    sum -= ((c_2 - c_1) + 1);

            //}
            //sum -= ((c_2 - c_1) + 1);
            //return sum;
            #endregion

            ////List<(long, long, long)> trackTuple = new List<(long, long, long)>();
            ////track.ForEach(i =>
            ////{
            ////    trackTuple.Add((i[0], i[1], i[2]));
            ////});
            //Dictionary<int, List<(int, int)>> keyValuePairs = new Dictionary<int, List<(int, int)>>();
            ///*
            // i. girdi icin
            //[(1,2)]

            // */
            //int r = -1;
            //int c_1 = 0;
            //int c_2 = -1;
            //int sum = 0;
            //for (int i = 0; i < k; i++)
            //{
            //    int _r = track[i][0];
            //    int track[i - 1] = track[i][1];
            //    int _c_2 = track[i][2];
            //    for (int j = track[i - 1] - 1; j <= _c_2 - 1; j++)
            //    {
            //        //Console.Write(i);
            //        Console.Write("{0}, {1}*", track[i - 1], _c_2);
            //        sum++;
            //        //keyValuePairs.Add(i+1, 1);
            //    }
            //    Console.WriteLine();
            //}


            #region MyRegion

            //foreach (var item in trackTuple)
            //{
            //    int _r = item.Item1;
            //    int track[i - 1] = item.Item2;
            //    int _c_2 = item.Item3;

            //    if (_r != r || track[i - 1] > c_2)
            //    {
            //        sum += ((c_2 - c_1) + 1);
            //        r = _r;
            //        c_1 = track[i - 1];
            //        c_2 = _c_2;
            //    }
            //    else if (_c_2 > c_2)
            //    {
            //        c_2 = _c_2;
            //    }
            //}

            //sum += ((c_2 - c_1) + 1);
            ////return ((n * m) - sum);
            ////return sum;
            //return 0;





            //int r = 0;
            //int c_1 = 0;
            //int c_2 = 0;

            //foreach (var item in trackTuple) // (2,2,3) seklinde ilk tuple elemandan baslayip ilerliyorsun.
            //{
            //    int _r = item.Item1;
            //    int track[i - 1] = item.Item2;
            //    int _c_2 = item.Item3;

            //    if (_r != r)// o an ki bulundugu row u kontrol ediyorum
            //    {

            //    }

            //    Console.WriteLine("r: {0}     c_1: {1}    c_2: {2}", item.Item1, item.Item2, item.Item3);

            //    for (int i = Math.Min(item.Item1, item.Item2) - 1; i < Math.Max(item.Item1, item.Item2); i++)
            //    {
            //        //t.Add((item.Item1, i[1], i[2]));
            //        //Console.Write("{0}", i);
            //        //if (i + 1 == item.Item1)
            //        //{
            //        //    //Console.Write("bu rda islem yap : {0}\t", item.Item1);
            //        //    //Console.Write("{0}'dan {1}' a kadar olan kismi topla.", item.Item2, item.Item3);
            //        /**/
            //        //}

            //    }
            //    Console.WriteLine();
            //}


            #endregion

            //return 0;
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {

            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int m = Convert.ToInt32(firstMultipleInput[1]);

            int k = Convert.ToInt32(firstMultipleInput[2]);

            List<List<int>> track = new List<List<int>>();

            for (int i = 0; i < k; i++)
            {
                track.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(trackTemp => Convert.ToInt32(trackTemp)).ToList());
            }

            long result = Result.gridlandMetro(n, m, k, track);

            Console.WriteLine(result);
        }
    }

}
//106462064813652574


//380943854889463711
//380943886166622720
//380943854889465093
