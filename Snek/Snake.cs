using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Snek
{
    [Serializable]
    public class Snake
    {
        public List<BodyPart> snake { get; set; }
        public Direction Dir { get; set; }

        public Color Color { get; set; }


        public Snake()
        {
            snake = new List<BodyPart>();
            Dir = Direction.Left;
            Color = Color.Green;
        }

        ~Snake() { }

        public void grow()
        {
            BodyPart head = snake[snake.Count - 1];
            snake.Add(head);
        }

        internal void Move()
        {
            snake.Remove(snake.First());
            snake.Add(MakeHead());
            snake.Last().move(Dir);
        }

        public BodyPart MakeHead()
        {
            return new BodyPart(snake.Last().X, snake.Last().Y, snake.Last().Radius);
        }

        public BodyPart this[int index]
        {
            get
            {
                if (index >= snake.Count)
                    return (BodyPart)null;
                return (BodyPart)snake[index];
            }
            set
            {
                if (index <= snake.Count)
                    snake[index] = value;
            }
        }

        internal bool IsHitTail()
        {
            var head = snake.Last();
            for (int i = 0; i < snake.Count - 3; i++)
            {
                if (head.IsOn(snake[i]))
                {
                    return true;
                }
            }
            return false;
        }

        public void CheckWalls()
        {
            if (snake[snake.Count - 1].X > 432)
            {
                snake[snake.Count - 1].X = 2;
            }
            else if (snake[snake.Count - 1].Y > 375)
            {
                snake[snake.Count - 1].Y = 2;
            }
            else if (snake[snake.Count - 1].X < 2)
            {
                snake[snake.Count - 1].X = 432;
            }
            else if (snake[snake.Count - 1].Y < 2)
            {
                snake[snake.Count - 1].Y = 375;
            }
        }

    }
}
