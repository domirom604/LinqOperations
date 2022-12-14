using System;
using System.Linq;

namespace LinqOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n1 = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
            string[] months = { "January", "February", "March", "April", "May","June", "July", "August", "September", "October", "November","December" };
            int[] result =null;
            Task task = new Task();
            Console.WriteLine("[{0}]", string.Join(", ", task.Task_1(n1)));

            Console.WriteLine("[{0}]", string.Join(", ", task.Task_2(n1)));

            Console.WriteLine("[{0}]", string.Join(", ", task.Task_3()));

            Console.WriteLine("[{0}]", string.Join(", ", task.Task_4()));

            var lines = task.Task_5().Select(kvp => kvp.Key + ": " + kvp.Value.ToString());
            Console.WriteLine("{0}", string.Join(", ", lines));

            lines = task.Task_6().Select(kvp => kvp.Key + ": " + kvp.Value.ToString());
            Console.WriteLine("{0}", string.Join(", ", lines));

            Console.WriteLine("{0}", string.Join(", ", months));

            var a = task.Task_8();
            Console.WriteLine("Keys: "+string.Join(",",a[1]));
            Console.WriteLine("Sum: "+string.Join(",", a[0]));
            Console.WriteLine("Count: "+string.Join(",", a[2]));

            Console.WriteLine("[{0}]", string.Join(", ", task.Task_9('N','I')));
            
            task.Task_10(8);
            task.Task_11(3);
            task.Task_12(3);
            task.Task_13_and_14();
            Students student = new Students();
            task.Task_15(student.GtStuRec(),3);

            task.Task_16();
            task.Task_17(9);
            task.Task_18();
            task.Task_19();
            task.Task_20();
            task.Task_21();
        }
    }
}
