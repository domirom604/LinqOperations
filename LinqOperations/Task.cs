using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqOperations
{
    class Task
    {
        List<int> list = new List<int>();
        public Task()
        {
            list.Add(14);
            list.Add(4);
            list.Add(8);
            list.Add(2);
            list.Add(9);
            list.Add(17);
            list.Add(12);
            list.Add(7);

            List<Item_mast> itemlist = new List<Item_mast>
             {
             new Item_mast { Id = 1, Descr = "A" },
             new Item_mast { Id = 2, Descr = "B" },
             new Item_mast { Id = 3, Descr = "C" },
             new Item_mast { Id = 4, Descr = "D" },
             new Item_mast { Id = 5, Descr = "E" }
             };

            List<Purchase> purchlist = new List<Purchase>
             {
             new Purchase { No=100,  Id = 3, Qty = 55 },
             new Purchase { No =101, Id = 2, Qty = 44 },
             new Purchase { No =102, Id = 3, Qty = 555 },
             new Purchase { No =103, Id = 4, Qty = 33 },
             new Purchase { No =104, Id = 3, Qty = 33 },
             new Purchase { No =105, Id = 4, Qty = 44 },
             new Purchase { No =106, Id = 1, Qty = 343 }
             };
        }
       
        public int[] Task_1(int[] n1)
        {
            IEnumerable<int> scoreQuery = from item in n1 where item % 2 == 0 select item;
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
            IEnumerable<int> scoreQuery = from item in arr1 where item > 0 && item < 12 select item;
            arr1 = scoreQuery.ToArray();
            return arr1;
        }
        public int[] Task_4()
        {
            var arr1 = new[] { 3, 9, 2, 8, 6, 5 };
            IEnumerable<int> scoreQuery = from item in arr1 where item * item > 20 select item;
            arr1 = scoreQuery.ToArray();
            return arr1;
        }
        public IDictionary<int, int> Task_5()
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
            int[][] result = new int[3][];
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
        public string[] Task_9(char start, char end)
        {
            IEnumerable<string> result;
            string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };
            result = from city in cities where city.First() == start && city.Last() == end select city;
            cities = result.ToArray();
            return cities;
        }

        public List<int> Task_10(int wartoscZKlawiatury)
        {
            list = list.FindAll(element => element > wartoscZKlawiatury);
            return list;
        }

        public List<int> Task_11(int numberOfLastElement)
        {
            var lis = list.Take(numberOfLastElement);
            return list;
        }
        public List<int> Task_12(int numberOfElement)
        {
            list.Sort();
            list.Reverse();
            var lis = list.Take(numberOfElement);
            return list;
        }

        public void Task_13_and_14()
        {
            IEnumerable<char> result;
            string str = "abZddwkKecjjeksoMZekcllkenKdkwel";
            result = (from charakters in str where charakters.Equals(Char.ToUpper(charakters)) select charakters);
            string upperCasOnly = "";
            result = result.ToArray();
            upperCasOnly = string.Join("",result);
        }
        public void Task_15(List<Students> students, int nValue)
        {
            students = students.OrderBy(o => o.GroupPoint).ToList();
            students.Reverse();
            var bestSTudents = students.Take(nValue);
        }
        public void Task_16()
        {
            string[] arr1 = { "a.erc", "b.txt","c.ldd","d.pdf", "e.PDF","a.pdf", "b.xml", "z.txt", "zzz.doc" };
            var dictionary = arr1.GroupBy(item => item.Substring(2).ToLower()).ToDictionary(p => p.Key, q => q.Count());
        }

        public void Task_17(int itemToDelate)
        {
            int[] arr1 = { 5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2 };
            List<int> numbers = arr1.ToList();
            var itemToRemove =numbers.FirstOrDefault(en => en == itemToDelate);
            numbers.Remove(itemToRemove);

        }

        public void Task_18()
        {
            char[] charset1 = { 'A', 'B', 'C', 'D' };
            int[] numset1 = { 1, 2, 3, 4 };
            var query = from x in charset1 from y in numset1 select new { x, y };
        }

        public void Task_19()
        {

        }
        public void Task_20()
        {

        }
        public void Task_21()
        {
        }


    }

}
