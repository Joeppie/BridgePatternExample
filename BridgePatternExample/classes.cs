using System;

namespace BridgePatternExample.Wrong
{


    public abstract class Shape
    {
        public abstract void Draw();
    }

    public class Circle : Shape
    {
        public override void Draw()
        {
            throw new NotImplementedException();
        }
    }

    public class RedCircle : Circle { }
    public class BlueCircle : Circle { }
    public class RedSquare : Square { }
    public class BlueSquare : Square { }

    public class Square : Shape
    {
        public override void Draw()
        {
            throw new NotImplementedException();
        }
    }

}
