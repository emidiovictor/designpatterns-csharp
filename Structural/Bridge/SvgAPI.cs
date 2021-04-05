using System;

namespace Structural.Bridge
{
    public class SvgAPI : DrawApi
    {
        public override void DrawLine(int x1, int y1, int x2, int y2)
        {
            Console.WriteLine($"Draw a line {x1} {y2}" );
        }
    }
}