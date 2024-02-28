using System;
using System.Collections.Generic;

namespace pr_2
{
    public class Task_1
    {
        private int _maxRange = 24; // 10 + 14 num in журнал
        private int _minRange = 1;

        public void Start()
        {
            var numCount = 3;
            var nums = new List<int>();

            Console.WriteLine("Entry 3 numbers:");
            while (nums.Count < numCount)
            {
                var isInteger = int.TryParse(Console.ReadLine(), out var num);

                if (isInteger)
                    nums.Add(num);
                else
                    Console.WriteLine("Invalid input");
            }

            Console.WriteLine($"Numbers in range {_minRange} - {_maxRange}");
            foreach (var num in nums)
            {
                if (NumberInRange(num))
                    Console.WriteLine(num);
            }
        }

        private bool NumberInRange(int num)
        {
            return num <= _maxRange && num >= _minRange;
        }
    }
}
