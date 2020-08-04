using System;

namespace InABucket08042020
{

    class Program
    {
        static void Main(string[] args)
        {
            // You can declare all Kinds of variables.
            String walrus;
            double piesEaten;
            float weightOfTeacupPig;
            int grainsOfSand;

            // But declaing them just sets up the space for data
            // to use the variable, you have to put data IN it first!
            walrus = "Sir Leroy Jenkins III";
            piesEaten = 42.1;

            Console.WriteLine("Meet my pet Walrus, " + walrus);
            Console.WriteLine("He was a bit hungry today, and ate this many pies : ");
            Console.WriteLine(piesEaten);
        }
    }
}