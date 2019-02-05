using System;

namespace PokemonType
{
    class normalType
    {
        public static void normal()
        {
            Console.WriteLine("A pure Normal type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Fighting types.");
            Console.WriteLine("\tIs immune to: Ghost types.\n");
        }

        public static void normalFighting()
        {
            Console.WriteLine("A Normal / Fighting type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Fighting, Flying, Psychic and Fairy types.");
            Console.WriteLine("\tHalf damage from: Rock, Bug and Dark types.");
            Console.WriteLine("\tIs immune to: Ghost types.\n");
        }

        public static void normalFlying()
        {
            Console.WriteLine("A Normal / Flying type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Rock, Electric and Ice types.");
            Console.WriteLine("\tHalf damage from: Bug and Grass types.");
            Console.WriteLine("\tIs immune to: Ground and Ghost types.\n");
        }

        public static void normalPoison()
        {
            Console.WriteLine("A Normal / Poison type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Ground and Psychic types.");
            Console.WriteLine("\tHalf damage from: Poison, Bug, Grass and Fairy types.");
            Console.WriteLine("\tIs immune to: Ghost types.\n");
        }

        public static void normalGround()
        {
            Console.WriteLine("A Normal / Ground type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Fighting, Water, Grass and Ice types.");
            Console.WriteLine("\tHalf damage from: Poison and Rock types.");
            Console.WriteLine("\tIs immune to: Ghost and Electric types.\n");
        }

        public static void normalRock()
        {
            Console.WriteLine("A Normal / Rock type pokemon takes:\n");
            Console.WriteLine("\t4x damage from: Fighting types.");
            Console.WriteLine("\t2x damage from: Ground, Steel, Water and Grass types.");
            Console.WriteLine("\tHalf damage from: Normal, Flying, Poison and Fire types.");
            Console.WriteLine("\tIs immune to: Ghost types.\n");
        }

        public static void normalBug()
        {
            Console.WriteLine("A Normal / Bug type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Flying, Rock and Fire types.");
            Console.WriteLine("\tHalf damage from: Ground and Grass types.");
            Console.WriteLine("\tIs immune to: Ghost types.\n");
        }

        public static void normalGhost()
        {
            Console.WriteLine("A Normal / Ghost type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Dark types.");
            Console.WriteLine("\tHalf damage from: Poison and Bug types.");
            Console.WriteLine("\tIs immune to: Normal, Fighting and Ghost types.\n");
        }

        public static void normalSteel()
        {
            Console.WriteLine("A Normal / Steel type pokemon takes:\n");
            Console.WriteLine("\t4x damage from: Fighting types.");
            Console.WriteLine("\t2x damage from: Ground and Fire types.");
            Console.WriteLine("\tHalf damage from: Normal, Flying, Rock, Bug, Steel, Grass, Psychic, Ice, Dragon");
            Console.WriteLine("\tand Fairy types.");
            Console.WriteLine("\tIs immune to: Poison and Ghost types.\n");
        }

        public static void normalFire()
        {
            Console.WriteLine("A Normal / Fire type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Fighting, Ground, Rock and Water types.");
            Console.WriteLine("\tHalf damage from: Bug, Steel, Fire, Grass, Ice and Fairy types.");
            Console.WriteLine("\tIs immune to: Ghost types.\n");
        }

        public static void normalWater()
        {
            Console.WriteLine("A Normal / Water type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Fighting, Grass and Electric types.");
            Console.WriteLine("\tHalf damage from: Steel, Fire, Water and Ice types.");
            Console.WriteLine("\tIs immune to: Ghost types.\n");
        }

        public static void normalGrass()
        {
            Console.WriteLine("A Normal / Grass type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Fighting, Flying, Poison, Bug, Fire and Ice types.");
            Console.WriteLine("\tHalf damage from: Ground, Water, Grass and Electric types.");
            Console.WriteLine("\tIs immune to: Ghost types.\n");
        }

        public static void normalElectric()
        {
            Console.WriteLine("A Normal / Electric type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Fighting and Ground types.");
            Console.WriteLine("\tHalf damage from: Flying, Steel and Electric types.");
            Console.WriteLine("\tIs immune to: Ghost types.\n");
        }

        public static void normalPsychic()
        {
            Console.WriteLine("A Normal / Psychic type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Bug and Dark types.");
            Console.WriteLine("\tHalf damage from: Psychic typesl");
            Console.WriteLine("\tIs immune to: Ghost types.\n");
        }

        public static void normalIce()
        {
            Console.WriteLine("A Normal / Ice type pokemon takes:\n");
            Console.WriteLine("\t4x damage from: Fighting types.");
            Console.WriteLine("\t2x damage from: Rock, Steel and Fire types.");
            Console.WriteLine("\tHalf damage from: Ice types.");
            Console.WriteLine("\tIs immune to: Ghost types.");
        }

        public static void normalDragon()
        {
            Console.WriteLine("A Normal / Dragon type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Fighting, Ice, Dragon and Fairy types.");
            Console.WriteLine("\tHalf damage from: Fire, Water, Grass and Electric types.");
            Console.WriteLine("\tIs immune to: Ghost types.\n");
        }

        public static void normalDark()
        {
            Console.WriteLine("A Normal / Dark type pokemon takes:\n");
            Console.WriteLine("\t4x damage from: Fighting types.");
            Console.WriteLine("\t2x damage from: Bug and Fairy types.");
            Console.WriteLine("\tHalf damage from: Dark types.");
            Console.WriteLine("\tIs immune to: Ghost and Psychic types.\n");
        }

        public static void normalFairy()
        {
            Console.WriteLine("A Normal / Fairy type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Poison and Steel types.");
            Console.WriteLine("\tHalf damage from: Bug and Dark types.");
            Console.WriteLine("\tIs immune to: Ghost and Dragon types.\n");
        }
    }
}
