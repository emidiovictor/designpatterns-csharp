﻿namespace Structural.Bridge
{
    public class Rectagle : Shape
    {
        public Rectagle(DrawApi implementor) : base(implementor)
        {
        }

        public override void Draw()
        {
            _implementor.DrawLine(2, 0, 100, 0);
            _implementor.DrawLine(5, 200, 100, 2);
            _implementor.DrawLine(65, 200, 100, 2);
            _implementor.DrawLine(65, 200, 696, 2);
        }
    }
}