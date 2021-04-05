using System;

namespace Structural.Bridge
{
    public class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Line drawn using OPENGL");
            Shape line = new Line(new OpenGLAPI());
            line.Draw();
            Console.WriteLine();
            
            Console.WriteLine("Line drawn using SVG");
            Shape rectagle = new Rectagle(new SvgAPI());
            rectagle.Draw();
            Console.WriteLine();
            
            
        }
    }
}