using System;
using System.Collections.Generic;
using System.Linq;

namespace cs_hackerrank
{
    class Result
    {
        public static bool isWrong(int row, int col, List<List<int>> obstacles)
        {
            //Console.WriteLine(obstacles.Count());

            for (var i = 0; i < obstacles.Count(); i++)
            {
                //5 3
                //4 3
                //5 5
                //4 2
                //2 3
                if (row == obstacles[i][0] && col == obstacles[i][1])
                {
                    return true;
                }
            }
            return false;
        }
        public static int diagonalCount(int n, int r_q, int c_q, List<List<int>> obstacles)
        {
            int count = 0;
            int row = r_q;
            int col = c_q;
            while (row > 1 && col < n) // case 1
            {
                row--;
                col++;
                if (isWrong(row, col, obstacles))
                {
                    break;
                }
                count++;
            }
            row = r_q;
            col = c_q;
            while (row < n && col > 1) // case 2
            {
                row++;
                col--;
                if (r_q == n || c_q == 1)
                {
                    break;
                }
                if (isWrong(row, col, obstacles))
                {
                    break;
                }
                count++;
            }
            row = r_q;
            col = c_q;
            while (row < n && col < n) // case 3
            {
                row++;
                col++;
                if (isWrong(row, col, obstacles))
                {
                    break;
                }
                count++;
            }
            row = r_q;
            col = c_q;

            while (row > 1 && col > 1) // case 4
            {
                row--;
                col--;
                if (r_q == 1 || c_q == 1)
                {
                    break;
                }
                if (isWrong(row, col, obstacles))
                {
                    break;
                }
                count++;
            }
            return count;

        }
        public static int verticalCount(int n, int r_q, int c_q, List<List<int>> obstacles)
        {
            int count = 0;
            int row = r_q;
            // sagdan sola
            while (row > 1)
            {
                row--;
                if (isWrong(row, c_q, obstacles)) // engel ile karsilasana kadar
                {
                    break;
                }
                count++;
            }
            row = r_q;
            // soldan saga
            while (row < n)
            {
                row++;
                if (isWrong(row, c_q, obstacles)) // engel ile karsilasana kadar
                {
                    break;
                }
                count++;
            }
            return count;
        }
        public static int horizontalCount(int n, int r_q, int c_q, List<List<int>> obstacles)
        {
            int count = 0;
            int col = c_q;
            // yukaridan asagi 
            while (col > 1)
            {
                col--;
                if (isWrong(r_q, col, obstacles)) // engel ile karsilasana kadar
                {
                    break;
                }
                count++;
            }
            col = c_q;
            // asagidan yukari
            while (col < n)
            {
                col++;
                if (isWrong(r_q, col, obstacles)) // engel ile karsilasana kadar
                {
                    break;
                }
                count++;
            }
            return count;
        }




        public static int queensAttack(int n, int k, int r_q, int c_q, List<List<int>> obstacles)
        {


            HashSet<(int, int)> directions = new HashSet<(int, int)> {
                (1, -1), (-1, 1), // sol yukari ve sag asagi
                (1, 1), (-1, -1), // sag yukari ve sol asagi
                (1, 0), (-1, 0), // yukari ve asagi
                (0, -1), (0, 1), // sola ve saga
            };
            HashSet<(int, int)> obstacle = new HashSet<(int, int)>();

            obstacles.ForEach(i =>
            {
                obstacle.Add((i[0], i[1]));
                //Console.WriteLine((i[0], i[1]).Item1);
            });
            //Console.WriteLine(obstacle.Contains((2,3)));
            //Console.WriteLine(obstacle.GetType());


            //foreach (var item in directions)
            //{
            //    Console.WriteLine(item);
            //}
            // (1, -1) den baslayip diger yonlerin hepsinde ilerleme kaydedecek

            int count = 0;
            foreach (var d in directions)
            {
                int x = r_q;
                int y = c_q;
                while (true)
                {
                    x += d.Item1;
                    y += d.Item2;
                    if (obstacle.Contains((x, y)))
                    {
                        break;
                    }
                    //if (x == c_q || y == r_q)
                    //{
                    //    break;
                    //}
                    if (x == 0 || y == 0)
                    {
                        break;
                    }
                    if (x == n + 1 || y == n + 1)
                    {
                        break;
                    }

                    count++;
                }
            }

            return count;



            //int[,] board = new int[n, n];

            ///*
            //5(n) 3(k)
            //4 3(queen| (r_q,c_q) )
            //5 5(k_1)
            //4 2(k_2)
            //2 3(k_3)
            // */


            //////     column | column|
            //////row |       |       |
            //////row |       |       |
            //////row |       |       |
            //////..k
            ////int[,] obstacle = new int[k, 2];

            //Console.WriteLine("v : " + verticalCount(n, r_q, c_q, obstacles));
            //Console.WriteLine("h : " + horizontalCount(n, r_q, c_q, obstacles));
            //Console.WriteLine("d : " + diagonalCount(n, r_q, c_q, obstacles));
            //// obstacles

            //for (int i = 0; i < k; i++)
            //{
            //    board[(obstacles[i][0] - 1), (obstacles[i][1] - 1)] = 2;
            //}


            //#region PrintBoard
            //Console.WriteLine("oyun tahtasi");
            //for (int i = n; i >= 1; i--)
            //{
            //    for (int j = 1; j <= n; j++)
            //    {


            //        //Console.Write($"{i}-{j} ");
            //        if (i == r_q && j == c_q) // queen
            //        {
            //            board[i - 1, j - 1] = 9;
            //            //Console.Write($" {board[i - 1, j - 1]} ");
            //        }
            //        else if (j == c_q) // vertical
            //        {

            //            if (board[i - 1, j - 1] != 2)
            //            {
            //                board[i - 1, j - 1] = 1;
            //            }

            //            //else
            //            //{
            //            //    board[i - 1, j - 1] = 0;
            //            //}
            //            //board[i - 1, j - 1] = 3;


            //        }
            //        else if (i == r_q) // horizontal
            //        {
            //            if (board[i - 1, j - 1] != 2)
            //            {
            //                board[i - 1, j - 1] = 1;
            //            }
            //            //else
            //            //{
            //            //    board[i - 1, j - 1] = 0;
            //            //}
            //            //board[i - 1, j - 1] = 3;
            //        }



            //        Console.Write($"{board[i - 1, j - 1]} ");
            //    }
            //    Console.WriteLine();
            //}
            //#endregion



            //return 0;
            //return verticalCount(n, r_q, c_q, obstacles) + horizontalCount(n, r_q, c_q, obstacles) + diagonalCount(n, r_q, c_q, obstacles);
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int k = Convert.ToInt32(firstMultipleInput[1]);

            string[] secondMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int r_q = Convert.ToInt32(secondMultipleInput[0]);

            int c_q = Convert.ToInt32(secondMultipleInput[1]);

            List<List<int>> obstacles = new List<List<int>>();

            for (int i = 0; i < k; i++)
            {
                obstacles.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(obstaclesTemp => Convert.ToInt32(obstaclesTemp)).ToList());
            }

            int result = Result.queensAttack(n, k, r_q, c_q, obstacles);

            Console.WriteLine(result);
        }
    }

}
