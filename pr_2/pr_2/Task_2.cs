using System;

namespace pr_2
{
    public enum TriangleType { None, Equilateral, Isoscales, Versatile };

    partial class Task_2
    { 

        private float[] _triangleSides = new float[3];
        private bool _sideWasEntered = false;


        public void EnterTriangleData()
        {
            _triangleSides ??= new float[3];
            var currentSide = 0;

            while (true)
            {
                Console.WriteLine($"Enter side #{currentSide+1}:");
                var isFloat = float.TryParse(Console.ReadLine(), out var num);

                if (isFloat)
                {
                    _triangleSides[currentSide] = num;
                    currentSide++;
                }
                else
                    Console.WriteLine("Invalid input");

                if (currentSide == _triangleSides.Length)
                    break;
            }

            var isReal = TriangleIsReal();

            Console.WriteLine($"Triangle is real - {isReal}");

            if (isReal)
                _sideWasEntered = true;
            else
            {
                Console.WriteLine("triangle is not real. pls enter correct data");
                EnterTriangleData();
            }
        }

        public float PrintTrianglePerimetr(bool showMessage = false)
        {
            if (!_sideWasEntered)
            {
                Console.WriteLine("Triangle sides wasnt entered!");
                return 0;
            }

            var perimetr = 0f;
            for (int i = 0; i < _triangleSides.Length; i++)
            {
                perimetr += _triangleSides[i];
            }

            if (showMessage)
                Console.WriteLine($"Triangle perimetr - {perimetr}");

            return perimetr;
        }

        public double PrintTriangleSquare(bool showMessage =  false)
        {
            var s = PrintTrianglePerimetr() / 2;
            var square = Math.Sqrt(s * (s - _triangleSides[0]) * (s - _triangleSides[1]) * (s - _triangleSides[2]));

            if (showMessage)
                Console.WriteLine($"Triangle square - {square}");

            return square;
        }

        public bool TriangleIsReal()
        {
            return _triangleSides[0] + _triangleSides[1] > _triangleSides[2]
                && _triangleSides[0] + _triangleSides[2] > _triangleSides[1]
                && _triangleSides[1] + _triangleSides[2] > _triangleSides[0];
        }

        public TriangleType GetTriangleType()
        {
            if (_triangleSides[0] == _triangleSides[1] && _triangleSides[0] == _triangleSides[2])
                return TriangleType.Equilateral;

            if (_triangleSides[0] == _triangleSides[1] || _triangleSides[0] == _triangleSides[2] || _triangleSides[1] == _triangleSides[2])
                return TriangleType.Isoscales;

            if (_triangleSides[0] != _triangleSides[1] && _triangleSides[0] != _triangleSides[2] && _triangleSides[1] != _triangleSides[2])
                return TriangleType.Versatile;

            return TriangleType.None;
        }
    }
}
