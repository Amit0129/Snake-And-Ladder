namespace Snake_And_Ladder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            SnakeAndLadderBuilder snakeAndLadder = new SnakeAndLadderBuilder();
           
            const int WIN_POSITION = 100;
            int playerOnePosi = 0;
            int playerTwoPosi = 0;
            int diceCountPlayOne = 0;
            int diceCountPlayTwo = 0;

            bool player1 = true;
            bool player2 = false;

            while (playerOnePosi < WIN_POSITION && playerTwoPosi < WIN_POSITION)
            {

                if (player1)
                {
                    Console.WriteLine("Player One Playing");
                    diceCountPlayOne++;

                    int rollDice = random.Next(1, 7);
                    Console.WriteLine($"The value of dice after roll is : {rollDice}");

                    int checkOption = random.Next(1, 4);
                    Console.WriteLine("Check Option is {0}", checkOption);


                    if (checkOption == 1)
                    {
                        playerOnePosi = snakeAndLadder.NoPlay(playerOnePosi);
                        Console.WriteLine("Player One position now is {0}", playerOnePosi);
                        player1 = false;
                        player2 = true;
                    }
                    else if (checkOption == 2)
                    {
                        playerOnePosi = snakeAndLadder.Ladder(playerOnePosi, rollDice, WIN_POSITION);
                        Console.WriteLine("Player One position now is {0}", playerOnePosi);
                        player1 = false;
                        player2 = true;
                    }
                    else
                    {
                        playerOnePosi = snakeAndLadder.Snake(playerOnePosi, rollDice);
                        Console.WriteLine("Player One position now is {0}", playerOnePosi);
                        player1 = false;
                        player2 = true;

                    }
                }
                else
                {
                    Console.WriteLine("Player Two Playing");
                    diceCountPlayTwo++;

                    int rollDice = random.Next(1, 7);
                    Console.WriteLine($"The value of dice after roll is : {rollDice}");

                    int checkOption = random.Next(1, 4);
                    Console.WriteLine("Check Option is {0}", checkOption);


                    if (checkOption == 1)
                    {
                        playerTwoPosi = snakeAndLadder.NoPlay(playerTwoPosi);
                        Console.WriteLine("Player Two position now is {0}", playerTwoPosi);

                        player1 = true;
                        player2 = false;
                    }
                    else if (checkOption == 2)
                    {
                        playerTwoPosi = snakeAndLadder.Ladder(playerTwoPosi, rollDice, WIN_POSITION);
                        Console.WriteLine("Player Two position now is {0}", playerTwoPosi);
                        player1 = true;
                        player2 = false;
                    }
                    else
                    {
                        playerTwoPosi = snakeAndLadder.Snake(playerTwoPosi, rollDice);
                        Console.WriteLine("Player Two position now is {0}", playerTwoPosi);
                        player1 = true;
                        player2 = false;

                    }
                }
                Console.WriteLine();
                Console.WriteLine("=====*****=====");
            }
            if (playerOnePosi == WIN_POSITION)
            {
                Console.WriteLine("Player One Win");
                Console.WriteLine($"Total number of dice played by player 1 to win is : {diceCountPlayOne}");
            }
            if (playerTwoPosi == WIN_POSITION)
            {
                Console.WriteLine("Player Two Win");
                Console.WriteLine($"Total number of dice played by player 2 to win is : {diceCountPlayTwo}");
            }



            

        }
    }
}