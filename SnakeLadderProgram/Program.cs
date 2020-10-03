using System;
namespace SnakeAndLadderSimulator
{
    class Program
    {
        public const int NoPlay = 0;
        public const int Ladder = 1;
        public const int Snake = 2;
        public const int WinPosition = 100;
        public const int StartPosition = 0;
        //Returns Output Of Die Roll
        public static int rollTheDie()
        {
            Random random = new Random();
            int numberOnDie = random.Next(1, 7);
            return numberOnDie;
        }
        //Returns the forward or the backward movement of the player
        public static int newPosition(int numberOnDie)
        {
            int toAdd = 0;
            Random random = new Random();
            int toMove = random.Next(0, 3);
            switch (toMove)
            {
                case NoPlay:
                    break;
                case Ladder:
                    toAdd = numberOnDie;
                    break;
                case Snake:
                    toAdd = -numberOnDie;
                    break;
            }
            return toAdd;
        }
        static void Main(string[] args)
        {
            //Welcome msg
            Console.WriteLine("Welcome to the Snake and Ladder Problem!");
            //Initialising
            int currentPosition = 0;
            Console.WriteLine("Starting position = "+ currentPosition);
	    int numberOnDie = rollTheDie();
            Console.WriteLine("Number on Die rolled = " + numberOnDie);
            //checking for an option out of three
            Console.WriteLine("New position = " + newPosition(numberOnDie));
            int currentPosition = 0, nextPosition;
            int count = 0;
            while (currentPosition < StartPosition)
            {
                int numberOnDie = rollTheDie();
                count++;
                int toAdd = newPosition(numberOnDie);
                nextPosition = currentPosition + toAdd;
                //checking if player has moved below position 0
                if (nextPosition < 0)
                    currentPosition = 0;
                else
                    currentPosition = nextPosition;
            }
            Console.WriteLine("Number on Die rolled = " + count);
            Console.WriteLine("Final Position of Player = " + currentPosition);
        }
    }
}