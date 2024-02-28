using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr_2
{
    class Task_3
    {
        private int[] _numbers = new int[24];

        public void Start()
        {
            for (int i = 0; i < _numbers.Length; i++)
            {
                var isInteger = int.TryParse(Console.ReadLine(), out var num);

                if (isInteger)
                    _numbers[i] = num;
                else
                    Console.WriteLine("Invalid input");
            }
        }

        public void PrintArray()
        {
            Console.WriteLine("Numbers in array: ");
            for (int i = 0; i < _numbers.Length; i++)
            {
                Console.WriteLine(_numbers[i]);
            }

            Console.WriteLine($"Max Value {MaxValue()}");
            Console.WriteLine($"Min Value {MinValue()}");
        }

        public int MaxValue() => _numbers.Max();
        public int MinValue() => _numbers.Min();
    }
}
