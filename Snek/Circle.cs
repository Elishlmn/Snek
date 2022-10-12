using System;
using System.Drawing;

namespace Snek
{
    [Serializable]
    public class Circle// all renderables
    {
        public int X { get; set; }
        public int Y { get; set; } 
        public int Radius { get; set; }


        public Circle() { X = 30; Y = 3; Radius = 5; }

        public Circle(int x, int y) { X = x; Y = y; }

        ~Circle() { }

        public bool IsOn(Circle c)
        {
            return c.X > X - 10 && c.X < X + 10 && c.Y > Y - 10 && c.Y < Y + 10;
        }

        public virtual void Draw(Graphics g, Color color) { }

    }
}
