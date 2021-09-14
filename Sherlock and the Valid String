using System;
using System.Collections.Generic;

namespace cs_hackerrank_sherlock_and_the_valid_string
{
    class Result
    {
       

        public static String isValid(String s)
        {

            var freqDict = new Dictionary<char, int>();
            foreach (char letter in s.ToCharArray())// aabbccddeefghi = 'a','a','b','b','c','c','d','d','e','e','f','g','h','i'
            {
                //Console.WriteLine($"{letter} var mi? {freq.ContainsKey(letter)}");
                if (freqDict.ContainsKey(letter))
                {
                    // harflerin frekansi  
                    //Console.WriteLine(freq[letter]);
                    freqDict[letter] += 1;
                }
                else
                {
                    freqDict[letter] = 1;
                }

            }
            // not dublicate
            var uniqVal = new HashSet<int>();
            foreach (int f in freqDict.Values)
            {
                Console.WriteLine($"frekans count {f}"); // hangi harften kac tane var.
                uniqVal.Add(f);
            }

            // cesitlilik sayisi 
            foreach (var item in uniqVal)
            {

                Console.WriteLine("*" + item);
            }


            // cesitlilik sayisi 1 ise 
            if (uniqVal.Count == 1)
            {
                return "YES";
            }
            // iki farkli frekans varsa
            else if (uniqVal.Count == 2)
            {

                var val1 = 0;
                var val2 = 0;
                var val1Count = 0;
                var val2Count = 0;
                var count = 0;
                // bu dongu 2 kere hash mapteki farklilik kadar donecek ama if kontrolu ile kontrol ettigimiz icin 2 kez donecek.
                foreach (int n in uniqVal) //aabbccddeefghi
                {
                    if (count == 0)
                    {
                        val1 = n;
                    }
                    else
                    {
                        val2 = n;
                    }
                    count++;
                }
                foreach (int f in freqDict.Values) // burasi da maksimum 26 27 kez donecek
                {
                    if (f == val1)
                    {
                        val1Count++;
                    }
                    if (f == val2)
                    {
                        val2Count++;
                    }
                }
                // &&and || or
                if ((val1 == 1 && val1Count == 1) || (val2 == 1 && val2Count == 1))
                {
                    return "YES";
                }
                else if ((val1Count == 1 || val2Count == 1) && Math.Abs((val1 - val2)) == 1)
                {
                    return "YES";
                }
                else
                {
                    return "NO1";
                }


                //return "YES";

            }
            // cesitlilik sayisi 2 den fazla ise  
            else
            {
                return "NO2";
            }
        }



    }

    class Program
    {
        public static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string result = Result.isValid(s);

            Console.WriteLine(result);
        }
    }

}
