using System;

namespace spel
{
    class Program
    {
        static void Main(string[] args)
        {
            string weponChoise;


            StartConvo();
            weponChoise = Console.ReadLine();

            if (weponChoise == "Sword")
            {
                SwordStart();

            }


            Console.ReadLine();

        }


        static void StartConvo()
        {


            Console.WriteLine("You find yourself in a dark dungeon. You stumble upon a skeleton, in its right han it holds a bow and in its left hand it holds a sword witch one do you pick up?");
        }

        static void BowStart()
        {
            Console.WriteLine("You pick up the bow and some arrows, there are two doors in front of you do you take door 1 or 2?");

        }

        static void SwordStart()
        {

            Console.WriteLine("You pick up the sword, there are two doors in front of you do you take door 1 or 2?");

        }

    }
}
