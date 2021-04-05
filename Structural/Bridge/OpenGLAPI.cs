using System;

namespace Structural.Bridge
{
    public class OpenGLAPI : DrawApi
    {
        public override void DrawLine(int x1, int y1, int x2, int y2)
        {
            Console.WriteLine("glBegins(GL_LINES");
            Console.WriteLine($"glVertex2i{x1}, {y1}");
            Console.WriteLine($"glVertex2i{x2}, {y2}");
            Console.WriteLine("glEnd()");
        }
    }
}