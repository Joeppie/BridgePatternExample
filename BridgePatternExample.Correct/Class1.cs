using System;

namespace BridgePatternExample.Correct
{

    public abstract class ColorImplementation
    {
        public abstract ConsoleColor Color { get;}
    }

    

    public abstract class Shape
    {
        private ColorImplementation _colorImplementation;

        ConsoleColor[,] drawing = new ConsoleColor[10, 10];

        public void DrawPixel(int x, int y)
        {
            drawing[x, y] = _colorImplementation.Color;
        }


    }



}
