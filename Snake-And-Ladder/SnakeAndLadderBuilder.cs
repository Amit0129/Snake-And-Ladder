using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_And_Ladder
{
    public class SnakeAndLadderBuilder
    {
        public void GetPosition()
        {
            int position = 0;
            Console.WriteLine($"Player current position is {position}");
            Random random= new Random();
            int diceRoll = random.Next( 1, 7 );
            Console.WriteLine($"The value come after rolling dice is {diceRoll}");
        }
    }
}
