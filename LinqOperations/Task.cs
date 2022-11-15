using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqOperations
{
    class Task
    {
        public int [] Task_1(int [] n1)
        {
            IEnumerable<int> scoreQuery = from item in n1 where item%2==0 select item;
            n1 = scoreQuery.ToArray();
            return n1;
        }
        public int[] Task_2(int[] n1)
        {
            IEnumerable<int> scoreQuery = from item in n1 where item % 2 != 0 select item;
            n1 = scoreQuery.ToArray();
            return n1;
        }
        public int[] Task_3()
        {
            var arr1 = new[] { 3, -1, -3, 6, 9, 2, -7, 0, 8, 14, 13, 24, 12, 6, 5 };
            IEnumerable<int> scoreQuery = from item in arr1 where item > 0 && item<12 select item;
            arr1 = scoreQuery.ToArray();
            return arr1;
        }
        public int[] Task_4()
        {
            var arr1 = new[] { 3, 9, 2, 8, 6, 5 };
            IEnumerable<int> scoreQuery = from item in arr1 where item*item>20 select item;
            arr1 = scoreQuery.ToArray();
            return arr1;
        }
        public IDictionary<int,int> Task_5()
        {
            int[] arr1 = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };
            var dictionary = arr1.GroupBy(item => item).ToDictionary(p => p.Key, q => q.Count());
            return dictionary;
        }
        public IDictionary<char, int> Task_6()
        {
            var str = "abeddwkkecjjeksoiekcllkenndkwel";
            var dictionary = str.GroupBy(item => item).ToDictionary(p => p.Key, q => q.Count());
            return dictionary;
        }
        public int[][] Task_8()
        {
            int [][] result = new int[3][];
            result[0] = new int[5];
            result[1] = new int[4];
            result[2] = new int[2];
            int[] nums = new int[] { 5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2 };
            var dictionary = nums.GroupBy(item => item).ToDictionary(p => p.Key, z => z.Sum());
            var dictionary2 = nums.GroupBy(item => item).ToDictionary(p => p.Key, q => q.Count());
            result[0] = new int[dictionary.Count];
            result[1] = new int[dictionary.Count];
            result[2] = new int[dictionary.Count];

            dictionary.Keys.CopyTo(result[1], 0);
            dictionary.Values.CopyTo(result[0], 0);
            dictionary2.Values.CopyTo(result[2], 0);

            return result;
        }
        public string[] Task_8()
        {
            string[] cities ={ "ROME","LONDON","NAIROBI","CALIFORNIA","ZURICH","NEW DELHI","AMSTERDAM","ABU DHABI", "PARIS" };

            return cities;
        }

    }

}
