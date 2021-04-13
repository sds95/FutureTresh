using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceString
{
    public class SortString
    {
        public static void SortAndPrint(string str)
        {
            Console.WriteLine($"Initial string:/n{str}");
            List<string> unsorted = new List<string>();
            unsorted = str.Split( ' ' ).ToList();
            List<string> sorted = MergeSort(unsorted);
            string result = String.Join(",", sorted.ToArray());
            Console.WriteLine($"Result string: {result}");
        }

        private static List<string> MergeSort(List<string> unsorted)
        {
            if (unsorted.Count <= 1)
                return unsorted;

            List<string> left = new List<string>();
            List<string> right = new List<string>();

            int middle = unsorted.Count / 2;
            for (int i = 0; i < middle; i++)  //Dividing the unsorted list
            {
                left.Add(unsorted[i]);
            }
            for (int i = middle; i < unsorted.Count; i++)
            {
                right.Add(unsorted[i]);
            }

            left = MergeSort(left);
            right = MergeSort(right);
            return Merge(left, right);
        }

        private static List<string> Merge(List<string> left, List<string> right)
        {
            List<string> result = new List<string>();

            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left.First()[0] <= right.First()[0])  //Comparing First two elements to see which is smaller
                    {
                        result.Add(left.First());
                        left.Remove(left.First());      //Rest of the list minus the first element
                    }
                    else
                    {
                        result.Add(right.First());
                        right.Remove(right.First());
                    }
                }
                else if (left.Count > 0)
                {
                    result.Add(left.First());
                    left.Remove(left.First());
                }
                else if (right.Count > 0)
                {
                    result.Add(right.First());

                    right.Remove(right.First());
                }
            }
            return result;
        }
    }
}
