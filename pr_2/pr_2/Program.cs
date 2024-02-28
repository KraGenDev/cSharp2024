using System;

namespace pr_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //var task1 = new Task_1();
            //task1.Start();

            var task_2 = new Task_2();
            task_2.EnterTriangleData();
            task_2.PrintTrianglePerimetr(true);
            task_2.PrintTriangleSquare(true);
            var type = task_2.GetTriangleType();
            Console.WriteLine($"Triangle type {type}");

            //Console.WriteLine($"Triangle type {type}");

            //var task_3 = new Task_3();
            //task_3.Start();
            //task_3.PrintArray();
        }
    }
}
