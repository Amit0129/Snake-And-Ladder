namespace Snake_And_Ladder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int position = 0;
            Console.WriteLine($"Player current position is {position}");
            Random random = new Random();
            
            
            
            SnakeAndLadderBuilder snakeAndLadder = new SnakeAndLadderBuilder();
            while (position<100)
            {
                int diceRoll = random.Next(1, 7);
                Console.WriteLine($"The value come after rolling dice is {diceRoll}");
                int option = random.Next(1, 4);
                switch (option)
                {
                    case 1:
                        position = snakeAndLadder.NoPlay(position);
                        Console.WriteLine("Player position now is " + position);
                        break;
                    case 2:
                        position = snakeAndLadder.Ladder(position, diceRoll);
                        Console.WriteLine("Player position now is " + position);
                        break;
                    default:
                        position = snakeAndLadder.Snake(position, diceRoll);
                        Console.WriteLine("Player position now is " + position);
                        break;
                }
            }
            

        }
    }
}