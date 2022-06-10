using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblem
{
    class AnagramDetector
    {
        public const int MAX = 256;

        public static bool compare(char[] arr1,
                                   char[] arr2)
        {
            for (int i = 0; i < MAX; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    return false;
                }
            }
            return true;
        }

        public static void search(string pat,
                                  string txt)
        {
            int M = pat.Length;
            int N = txt.Length;

            char[] countP = new char[MAX];
            char[] countTW = new char[MAX];
            for (int i = 0; i < M; i++)
            {
                (countP[pat[i]])++;
                (countTW[txt[i]])++;
            }

            for (int i = M; i < N; i++)
            {
                if (compare(countP, countTW))
                {
                    Console.WriteLine("Found at Index " + (i - M));
                }

                (countTW[txt[i]])++;

                countTW[txt[i - M]]--;
            }

            if (compare(countP, countTW))
            {
                Console.WriteLine("Found at Index " + (N - M));
            }
        }

    }

}
