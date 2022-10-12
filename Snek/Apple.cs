using System;
using System.Drawing;

namespace Snek
{
    [Serializable]
    public class Apple : Food // Red apple
    {
         
        //public int points;


        [NonSerialized] SolidBrush br;
        [NonSerialized] SolidBrush br2;
        [NonSerialized] Pen pen;

        public Apple()
        {
            X = random.Next(100, 200);
            Y = random.Next(100, 200);
            X = X - (X % 10) + 5;
            Y = Y - (Y % 10) + 5;
            Points = 1;
        }

        public Apple(int x, int y)
        {
            X = x - (x % 10) + 5;
            Y = y - (y % 10) + 5;
            Points = 1;
        }

        ~Apple() { }


        public override void Draw(Graphics g, Color color)
        {
            SolidBrush br = new SolidBrush(color);
            SolidBrush br2 = new SolidBrush(Color.Green);
            Pen pen = new Pen(Color.DarkRed, 2);
            g.FillEllipse(br, X - Radius, Y - Radius, 2 * Radius, 2 * Radius);
            g.DrawEllipse(pen, X - Radius, Y - Radius, 2 * Radius, 2 * Radius);
            g.FillEllipse(br2, X - Radius + 2, Y - Radius - 1, 0.8F * Radius, 1.2F * Radius);
        }

        public void DrawHover(Graphics g, Color color)
        {
            SolidBrush br = new SolidBrush(Color.FromArgb(50, color));
            SolidBrush br2 = new SolidBrush(Color.FromArgb(50, Color.Green));
            Pen pen = new Pen(Color.FromArgb(50, Color.DarkRed), 2);
            g.FillEllipse(br, X - Radius, Y - Radius, 2 * Radius, 2 * Radius);
            g.DrawEllipse(pen, X - Radius, Y - Radius, 2 * Radius, 2 * Radius);
            g.FillEllipse(br2, X - Radius + 2, Y - Radius - 1, 0.8F * Radius, 1.2F * Radius);
        }
    }
}
