using System;
using System.Text;

namespace BridgePatternExample.Correct
{

    public interface IColorImplementation
    {
        ConsoleColor Color { get; }
    }

    public class Red : IColorImplementation
    {
        public ConsoleColor Color => ConsoleColor.Red;
    }

    public class Blue : IColorImplementation
    {
        public ConsoleColor Color => ConsoleColor.Blue;
    }

    public abstract class Shape
    {
        private IColorImplementation _colorImplementation;

        protected const int _size = 10;
        protected ConsoleColor[,] _drawing = new ConsoleColor[_size, _size];

        public Shape(IColorImplementation colorImplementation)
        {
            _colorImplementation = colorImplementation;
            for (int x = 0; x < _size; x++)
                for (int y = 0; y < _size; y++)
                {
                    _drawing[x, y] = ConsoleColor.Black;
                }
        }


        public void DrawPixel(int x, int y)
        {
            _drawing[x, y] = _colorImplementation.Color;
        }

        public abstract void Draw();

        public void DepictInConsole()
        {
            Draw();
            for (int y = 0; y < _size; y++)
            {
                for (int x = 0; x < _size; x++)
                {
                    Console.ForegroundColor = _drawing[x, y];
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }
    }

    public class Circle : Shape
    {
        public Circle(IColorImplementation color) : base(color)
        {
        }

        public override void Draw()
        {
            int radius = _size;
            int middle = _size / 2;
            for (int x = 0; x < _size; x++)
                for (int y = 0; y < _size; y++)
                {
                    double dx = Math.Abs(x - middle);
                    double dy = Math.Abs(y - middle);

                    if (Math.Sqrt(dx * dx + dy * dy) <= radius)
                    {
                        DrawPixel(x, y);
                    }

                }
        }
    }

    public class Square : Shape
    {
        public Square(IColorImplementation color) : base(color)
        {
        }

        public override void Draw()
        {
            for (int x = 0; x < _size; x++)
                for (int y = 0; y < _size; y++)
                {
                        DrawPixel(x, y);
                }
        }
    }


}
