using System;
using System.Drawing;

namespace Snek
{
    [Serializable]
    public class GoldenApple : Food // spawns randomly, gives more points, has decay
    {

        [NonSerialized] SolidBrush br;
        [NonSerialized] SolidBrush br2;
        [NonSerialized] Pen pen;

        public int Opacity;
        public bool exist { get; set; } 

        public GoldenApple()
        {
            exist = false;
            Points = 5;
            Opacity = 255;
        }

        ~GoldenApple() { }

        public override void Eat(ref int score)
        {
            score += Points;
            exist = false;
            Opacity = 255;
        }

        public override void Draw(Graphics g, Color color)
        {
            SolidBrush br = new SolidBrush(Color.FromArgb(Opacity, color));
            SolidBrush br2 = new SolidBrush(Color.FromArgb(Opacity, Color.Green));
            Pen pen = new Pen(Color.FromArgb(Opacity, Color.Gold), 2);
            g.FillEllipse(br, X - Radius, Y - Radius, 2 * Radius, 2 * Radius);
            g.DrawEllipse(pen, X - Radius, Y - Radius, 2 * Radius, 2 * Radius);
            g.FillEllipse(br2, X - Radius + 2, Y - Radius - 1, 0.8F * Radius, 1.2F * Radius);
        }
    }
}
