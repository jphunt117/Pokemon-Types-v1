using System;

namespace PokemonType
{
    class groundType
    {
        public static void ground()
        {
            Console.WriteLine("A pure Ground type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Water, Grass and Ice types.");
            Console.WriteLine("\tHalf damage from: Poison and Rock types.");
            Console.WriteLine("\tIs immune to: Electric types.\n");
        }

        public static void groundNormal()
        {
            Console.WriteLine("A Ground / Normal type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Fighting, Water, Grass and Ice types.");
            Console.WriteLine("\tHalf damage from: Poison and Rock types.");
            Console.WriteLine("\tIs immune to: Ghost and Electric types.\n");
        }

        public static void groundFighting()
        {
            Console.WriteLine("A Ground / Fighting type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Flying, Water, Grass, Psychic, Ice and Fairy types.");
            Console.WriteLine("\tHalf damage from: Poison, Bug and Dark types.");
            Console.WriteLine("\tFourth the damage from: Rock types.");
            Console.WriteLine("\tIs immune to: Electric types.\n");
        }

        public static void groundFlying()
        {
            Console.WriteLine("A Ground / Flying type pokemon takes:\n");
            Console.WriteLine("\t4x damage from: Ice types.");
            Console.WriteLine("\t2x damage from: Water types.");
            Console.WriteLine("\tHalf damage from: Fighting, Poison and Bug types.");
            Console.WriteLine("\tIs immune to: Ground and Electric types.\n");
        }

        public static void groundPoison()
        {
            Console.WriteLine("A Ground / Poison type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Ground, Water, Psychic and Ice types.");
            Console.WriteLine("\tHalf damage from: Fighting, Rock, Bug and Fairy types.");
            Console.WriteLine("\tFourth the damage from: Poison types.");
            Console.WriteLine("\tIs immune to: Electric types.\n");
        }

        public static void groundRock()
        {
            Console.WriteLine("A Ground / Rock type pokemon takes:\n");
            Console.WriteLine("\t4x damage from: Water and Grass types.");
            Console.WriteLine("\t2x damage from: Fighting, Ground, Steel and Ice types.");
            Console.WriteLine("\tHalf damage from: Normal, Flying, Rock and Fire types.");
            Console.WriteLine("\tFourth the damage from: Poison types.");
            Console.WriteLine("\tIs immune to: Electric types.\n");
        }

        public static void groundBug()
        {
            Console.WriteLine("A Ground / Bug type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Flying, Fire, Water and Ice types.");
            Console.WriteLine("\tHalf damage from: Fighting, Poison and Ground types.");
            Console.WriteLine("\tIs immune to: Electric types.\n");
        }

        public static void groundGhost()
        {
            Console.WriteLine("A Ground / Ghost type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Ghost, Water, Grass, Ice and Dark types.");
            Console.WriteLine("\tHalf damage from: Rock and Bug types.");
            Console.WriteLine("\tFourth the damage from: Poison types.");
            Console.WriteLine("\tIs immune to: Normal, Fighting and Electric types.");
        }

        public static void groundSteel()
        {
            Console.WriteLine("A Ground / Steel type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Fighting, Ground, Fire and Water types.");
            Console.WriteLine("\tHalf damage from: Normal, Flying, Bug, Steel, Psychic, Dragon");
            Console.WriteLine("\tand Fairy types.");
            Console.WriteLine("\tFourth the damage from: Rock types.");
            Console.WriteLine("\tIs immune to: Poison and Electric types.\n");
        }

        public static void groundFire()
        {
            Console.WriteLine("A Ground / Fire type pokemon takes:\n");
            Console.WriteLine("\t4x damage from: Water types.");
            Console.WriteLine("\t2x damage from: Ground types.");
            Console.WriteLine("\tHalf damage from: Poison, Bug, Steel, Fire and Fairy types.");
            Console.WriteLine("\tIs immune to: Electric types.\n");
        }

        public static void groundWater()
        {
            Console.WriteLine("A Ground / Water type pokemon takes:\n");
            Console.WriteLine("\t4x damage from: Grass types.");
            Console.WriteLine("\tHalf damage from: Poison, Rock, Steel and Fire types.");
            Console.WriteLine("\tIs immune to: Electric types.\n");
        }

        public static void groundGrass()
        {
            Console.WriteLine("A Ground / Grass type pokemon takes:\n");
            Console.WriteLine("\t4x damage from: Ice types.");
            Console.WriteLine("\t2x damage from: Flying, Bug and Fire types.");
            Console.WriteLine("\tHalf damage from: Ground and Rock types.");
            Console.WriteLine("\tIs immune to: Electric types.");
        }

        public static void groundElectric()
        {
            Console.WriteLine("A Ground / Electric type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Ground, Water, Grass and Ice types.");
            Console.WriteLine("\tHalf damage from: Flying, Poison, Rock and Steel types.");
            Console.WriteLine("\tIs immune to: Electric types.\n");
        }

        public static void groundPsychic()
        {
            Console.WriteLine("A Ground / Psychic type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Bug, Ghost, Water, Grass, Ice and Dark types.");
            Console.WriteLine("\tHalf damage from: Fighting, Poison, Rock and Psychic types.");
            Console.WriteLine("\tIs immune to: Electric types.\n");
        }

        public static void groundIce()
        {
            Console.WriteLine("A Ground / Ice type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Fighting, Steel, Fire, Water and Grass types.");
            Console.WriteLine("\tHalf damage from: Poison types.");
            Console.WriteLine("\tIs immune to: Electric types.\n");
        }

        public static void groundDragon()
        {
            Console.WriteLine("A Ground / Dragon type pokemon takes:\n");
            Console.WriteLine("\t4x damage from: Ice types.");
            Console.WriteLine("\t2x damage from: Dragon and Fairy types.");
            Console.WriteLine("\tHalf damage from: Poison, Rock and Fire types.");
            Console.WriteLine("\tIs immune to: Electric types.\n");
        }

        public static void groundDark()
        {
            Console.WriteLine("A Ground / Dark type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Fighting, Bug, Water, Grass, Ice and Fairy types.");
            Console.WriteLine("\tHalf damage from: Poison, Rock, Ghost and Dark types.");
            Console.WriteLine("\tIs immune to: Electric and Psychic types.");
        }

        public static void groundFairy()
        {
            Console.WriteLine("A Ground / Fairy type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Steel, Water, Grass and Ice types.");
            Console.WriteLine("\tHalf damage from: Fighting, Rock, Bug and Dark types.");
            Console.WriteLine("\tIs immune to: Electric and Dragon types.\n");
        }
    }
}
