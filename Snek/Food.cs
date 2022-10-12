using System;

namespace Snek
{
    [Serializable]
    public abstract class Food : Circle // all consumables
    {

        public Random random { get; set; }

        public int Points;

        public Food()
        { 
            random = new Random();
        }

        ~Food() { }
        public virtual void Eat(ref int score)
        {
            score += Points;
        }



    }
}
