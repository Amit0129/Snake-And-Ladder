using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_And_Ladder
{
    public class SnakeAndLadderBuilder
    {
        public int NoPlay(int position)
        {
            Console.WriteLine("The option is Noplay");
            return position;    
        }
        public int Ladder(int position,int diceRoll) 
        {
            Console.WriteLine("The option is Ladder");
            position += diceRoll;
            if (position > 100)
            {
                position -= diceRoll;
            }
            return position;
        }
        public int Snake(int position,int diceRoll)
        {
            Console.WriteLine("The option is Snake");
            position -= diceRoll;
            if (position < 0)
            {
                position = 0;
            }
            return position;
        }
    }
}
