using System;

namespace PokemonType
{
    class electricType
    {
        public static void electric()
        {
            Console.WriteLine("A pure Electric type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Ground types.");
            Console.WriteLine("\tHalf damage from: Flying, Steel and Electric types.\n");
        }

        public static void electricNormal()
        {
            Console.WriteLine("An Electric / Normal type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Fighting and Ground types.");
            Console.WriteLine("\tHalf damage from: Flying, Steel and Electric types.");
            Console.WriteLine("\tIs immune to: Ghost types.\n");
        }

        public static void electricFighting()
        {
            Console.WriteLine("An Electric / Fighting type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Ground, Psychic and Fairy types.");
            Console.WriteLine("\tHalf damage from: Rock, Bug, Steel, Electric and Dark types.\n");
        }

        public static void electricFlying()
        {
            Console.WriteLine("An Electric / Flying type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Rock and Ice types.");
            Console.WriteLine("\tHalf damage from: Fighting, Flying, Bug, Steel and Grass types.");
            Console.WriteLine("\tIs immune to: Ground types.\n");
        }

        public static void electricPoison()
        {
            Console.WriteLine("An Electric / Poison type pokemon takes:\n");
            Console.WriteLine("\t4x damage from: Ground types.");
            Console.WriteLine("\t2x damage from: Psychic types.");
            Console.WriteLine("\tHalf damage from: Fighting, Flying, Poison, Bug, Steel");
            Console.WriteLine("\tGrass, Electric and Fairy types.\n");
        }

        public static void electricGround()
        {
            Console.WriteLine("An Electric / Ground type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Ground, Water, Grass and Ice types.");
            Console.WriteLine("\tHalf damage from: Flying, Poison, Rock and Steel types.");
            Console.WriteLine("\tIs immune to: Electric types.\n");
        }

        public static void electricRock()
        {
            Console.WriteLine("An Electric / Rock type pokemon takes:\n");
            Console.WriteLine("\t4x damage from: Ground types.");
            Console.WriteLine("\t2x damage from: Fighting, Water and Grass types.");
            Console.WriteLine("\tHalf damage from: Normal, Poison, Fire and Electric types.");
            Console.WriteLine("\tFourth the damage from: Flying types.\n");
        }

        public static void electricBug()
        {
            Console.WriteLine("An Electric / Bug type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Rock and Fire types.");
            Console.WriteLine("\tHalf damage from: Fighting, Steel, Grass and Electric types.\n");
        }

        public static void electricGhost()
        {
            Console.WriteLine("An Electric / Ghost type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Ground, Ghost and Dark types.");
            Console.WriteLine("\tHalf damage from: Flying, Poison, Bug, Steel and Electric types.");
            Console.WriteLine("\tIs immune to: Normal and Fighting types.\n");
        }

        public static void electricSteel()
        {
            Console.WriteLine("An Electric / Steel type pokemon takes:\n");
            Console.WriteLine("\t4x damage from: Ground types.");
            Console.WriteLine("\t2x damage from: Fighting and Fire types.");
            Console.WriteLine("\tHalf damage from: Normal, Rock, But, Grass, Electric");
            Console.WriteLine("\tPsychic, Ice, Dragon and Fairy types.");
            Console.WriteLine("\tFourth the damage from: Flying and Steel types.");
            Console.WriteLine("\tIs immune to: Poison types.\n");
        }

        public static void electricFire()
        {
            Console.WriteLine("An Electric / Fire type pokemon takes:\n");
            Console.WriteLine("\t4x damage from: Ground types.");
            Console.WriteLine("\t2x damage from: Rock and Water types.");
            Console.WriteLine("\tHalf damage from: Flying, Bug, Fire, Grass, Electric");
            Console.WriteLine("\tIce and Fairy types.");
            Console.WriteLine("\tFourth the damage from: Steel types.\n");
        }

        public static void electricWater()
        {
            Console.WriteLine("An Electric / Water type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Ground and Grass types.");
            Console.WriteLine("\tHalf damage from: Flying, Fire, Water and Ice types.");
            Console.WriteLine("\tFourth the damage from: Steel types.\n");
        }

        public static void electricGrass()
        {
            Console.WriteLine("An Electric / Grass type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Poison, Bug, Fire and Ice types.");
            Console.WriteLine("\tHalf damage from: Steel, Water and Grass types.");
            Console.WriteLine("\tFourth the damage from: Electric types.\n");
        }

        public static void electricPsychic()
        {
            Console.WriteLine("An Electric / Psychic type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Ground, Bug, Ghost and Dark types.");
            Console.WriteLine("\tHalf damage from: Fighting, Flying, Steel, Electric and Psychic types.\n");
        }

        public static void electricIce()
        {
            Console.WriteLine("An Electric / Ice type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Fighting, Ground, Rock and Fire types.");
            Console.WriteLine("\tHalf damage from: Flying, Electric and Ice types.\n");
        }

        public static void electricDragon()
        {
            Console.WriteLine("An Electric / Dragon type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Ground, Ice, Dragon and Fairy types.");
            Console.WriteLine("\tHalf damage from: Flying, Steel, Fire, Water and Grass types.");
            Console.WriteLine("\tFourth the damage from: Electric types.\n");
        }

        public static void electricDark()
        {
            Console.WriteLine("An Electric / Dark type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Fighting, Ground, Bug and Fairy types.");
            Console.WriteLine("\tHalf damage from: Flying, Ghost, Steel, Electric and Dark types.");
            Console.WriteLine("\tIs immune to: Psychic types.\n");
        }

        public static void electricFairy()
        {
            Console.WriteLine("An Electric / Fairy type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Poison and Ground types.");
            Console.WriteLine("\tHalf damage from: Fighting, Flying, Bug, Electric and Dark types.");
            Console.WriteLine("\tIs immune to: Dragon types.\n");
        }
    }
}
