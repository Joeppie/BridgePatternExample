using BridgePatternExample.Correct;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePatternDemoApp
{
    class Program
    {
        //Willekeurige vervanging van code vanuit elders.
        class White : IColorImplementation
        {
            public static White Instance { get; }
            static White()
            {
                Instance = new White();
            }
            public ConsoleColor Color => ConsoleColor.White;
        }

        static void Main(string[] args)
        {
            Shape RedCircle = new Circle(new Red());
            Shape BlueSquare = new Square(new Blue());
            Shape WhiteCircle = new Circle(White.Instance);

            RedCircle.DepictInConsole();
            BlueSquare.DepictInConsole();
            WhiteCircle.DepictInConsole();
        }
    }
}
