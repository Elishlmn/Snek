using System;
using System.Drawing;
using System.Windows.Forms;

namespace Snek
{
    [Serializable]
    public class BodyPart : Circle
    {

        [NonSerialized] SolidBrush br;
        [NonSerialized] Pen pen;

        public BodyPart()
        {
            X = 300 - (430 / 2 % 10) + 5;
            Y = 200 - (375 / 2 % 10) + 5;
            Radius = 5;
        }

        public BodyPart(int x, int y, int rad)
        {
            X = x;
            Y = y;
            Radius = rad;
        }

        public void move(Direction dir)
        {
            switch (dir)
            {
                case Direction.Left:
                    X -= 10;
                    break;
                case Direction.Right:
                    X += 10;
                    break;
                case Direction.Up:
                    Y -= 10;
                    break;
                case Direction.Down:
                    Y += 10;
                    break;
            }
        }

        public override void Draw(Graphics g, Color color)
        {
            SolidBrush br = new SolidBrush(color);
            Pen pen = new Pen(ControlPaint.Dark(color, 20) , 2);
            g.FillEllipse(br, X - Radius, Y - Radius, 2 * Radius, 2 * Radius);
            g.DrawEllipse(pen, X - Radius, Y - Radius, 2 * Radius, 2 * Radius);
        }

        public void DrawHead(Graphics g, Color color, Direction Dir)
        {
            SolidBrush br = new SolidBrush(color);
            Pen pen = new Pen(ControlPaint.Dark(color, 20), 2);
            g.FillEllipse(br, X - Radius, Y - Radius, (Dir == Direction.Right || Dir == Direction.Left ? 4 : 2) * Radius, (Dir == Direction.Right || Dir == Direction.Left ? 2 : 4) * Radius);
            g.DrawEllipse(pen, X - Radius, Y - Radius, (Dir == Direction.Right || Dir == Direction.Left ? 4 : 2) * Radius, (Dir == Direction.Right || Dir == Direction.Left ? 2 : 4) * Radius);
        }
    }
}
