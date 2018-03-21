using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscreteMathPack1
{
    public static class Permutation
    {
        public static void WritePermutations(int k = 3)
        {
            List<int> list = GenerateNumberList(k);
            StartGeneratingPermutations(list);
        }

        public static bool CheckIfListIsPermutation(List<int> list)
        {
            int unit;
            for (int i = 0; i < list.Count; i++)
            {
                unit = list[i];
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[i] == list[j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private static List<int> GenerateNumberList(int k)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < k; i++)
            {
                list.Add(i + 1);
            }
            return list;
        }

        private static void StartGeneratingPermutations(List<int> list)
        {
            Console.Write("Starting with input: ");
            WriteListToConsole(list);
            GeneratePermutations(list, list.Count - 1);
        }

        private static void GeneratePermutations(List<int> list, int k)
        {
            if (k == 0)
            {
                WriteListToConsole(list);
            }
            else
            {
                for (int i = 0; i <= k; i++)
                {
                    Swap(list, k, i);
                    GeneratePermutations(list, k - 1);
                    Swap(list, k, i);
                }
            }
        }

        private static void Swap(List<int> list, int k, int i)
        {
            int tmp = list[i];
            list[i] = list[k];
            list[k] = tmp;
        }

        private static void WriteListToConsole(List<int> list)
        {
            foreach (var item in list)
            {
                Console.Write(item);
                Console.Write(" ");

            }
            Console.WriteLine();
        }
    }

}
