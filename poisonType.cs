using System;

namespace PokemonType
{
    class poisonType
    {
        public static void poison()
        {
            Console.WriteLine("A pure Poison type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Ground and Psychic types.");
            Console.WriteLine("\tHalf damage from: Fighting, Poison, Bug, Grass and Fairy types.\n");
        }

        public static void poisonNormal()
        {
            Console.WriteLine("A Poison / Normal type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Ground and Psychic types.");
            Console.WriteLine("\tHalf damage from: Poison, Bug, Grass and Fairy types.");
            Console.WriteLine("\tIs immune to: Ghost types.\n");
        }

        public static void poisonFighting()
        {
            Console.WriteLine("A Poison / Fighting type pokemon takes:\n");
            Console.WriteLine("\t4x damage from: Psychic types.");
            Console.WriteLine("\t2x damage from: Flying and Ground types.");
            Console.WriteLine("\tHalf damage from: Fighting, Poison, Rock, Grass and Dark types.");
            Console.WriteLine("\tFourth the damage from: Bug types.\n");
        }

        public static void poisonFlying()
        {
            Console.WriteLine("A Poison / Flying type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Rock, Electric, Psychic and Ice types.");
            Console.WriteLine("\tHalf damage from: Poison and Fairy types.");
            Console.WriteLine("\tFourth the damage from: Fighting, Bug and Grass types.");
            Console.WriteLine("\tIs immune to: Ground types.\n");
        }

        public static void poisonGround()
        {
            Console.WriteLine("A Poison / Ground type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Ground, Water, Psychic and Ice types.");
            Console.WriteLine("\tHalf damage from: Fighting, Rock, Bug and Fairy types.");
            Console.WriteLine("\tFourth the damage from: Poison types.");
            Console.WriteLine("\tIs immune to: Electric types\n");
        }

        public static void poisonRock()
        {
            Console.WriteLine("A Poison / Rock type pokemon takes:\n");
            Console.WriteLine("\t4x damage from: Ground types.");
            Console.WriteLine("\t2x damage from: Steel, Water and Psychic types.");
            Console.WriteLine("\tHalf damage from: Normal, Flying, Bug, Fire and Fairy types.");
            Console.WriteLine("\tFourth the damage from: Poison types.\n");
        }

        public static void poisonBug()
        {
            Console.WriteLine("A Poison / Bug type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Flying, Rock, Fire and Psychic types.");
            Console.WriteLine("\tHalf damage from: Poison, Bug and Fairy types.");
            Console.WriteLine("\tFourth the damage from: Fighting and Grass types.\n");
        }

        public static void poisonGhost()
        {
            Console.WriteLine("A Poison / Ghost type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Ground, Ghost, Psychic and Dark types.");
            Console.WriteLine("\tHalf damage from: Grass and Fairy types.");
            Console.WriteLine("\tFourth the damage from: Poison and Bug types.");
            Console.WriteLine("\tIs immune to: Normal and Fighting types.\n");
        }

        public static void poisonSteel()
        {
            Console.WriteLine("A Poison / Steel type pokemon takes:\n");
            Console.WriteLine("\t4x damage from: Ground types.");
            Console.WriteLine("\t2x damage from: Fire types.");
            Console.WriteLine("\tHalf damage from: Normal, Flying, Rock, Steel, Ice and Dragon types.");
            Console.WriteLine("\tFourth the damage from: Bug, Grass and Fairy types.");
            Console.WriteLine("\tIs immune to: Poison types.");
        }

        public static void poisonFire()
        {
            Console.WriteLine("A Poison / Fire type pokemon takes:\n");
            Console.WriteLine("\t4x damage from: Ground types.");
            Console.WriteLine("\t2x damage from: Rock, Water and Psychic types.");
            Console.WriteLine("\tHalf damage from: Fighting, Poison, Steel, Fire and Ice types.");
            Console.WriteLine("\tFourth the damage from: Bug, Grass and Fairy types.\n");
        }

        public static void poisonWater()
        {
            Console.WriteLine("A Poison / Water type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Ground, Electric and Psychic types.");
            Console.WriteLine("\tHalf damage from: Fighting, Poison, Bug, Steel, Fire, Water, Ice and Fairy types.\n");
        }

        public static void poisonGrass()
        {
            Console.WriteLine("A Poison / Grass type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Flying, Fire, Psychic and Ice types.");
            Console.WriteLine("\tHalf damage from: Fighting, Water, Electric and Fairy types.");
            Console.WriteLine("\tFourth the damage from: Grass types.\n");
        }

        public static void poisonElectric()
        {
            Console.WriteLine("A Poison / Electric type pokemon takes:\n");
            Console.WriteLine("\t4x damage from: Ground types.");
            Console.WriteLine("\t2x damage from: Psychic types.");
            Console.WriteLine("\tHalf damage from: Fighting, Flying, Poison, Bug, Steel, Grass, Electric");
            Console.WriteLine("\tand Fairy types.\n");
        }

        public static void poisonPsychic()
        {
            Console.WriteLine("A Poison / Psychic type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Ground, Ghost and Dark types.");
            Console.WriteLine("\tHalf damage from: Poison, Grass and Fairy types.");
            Console.WriteLine("\tFourth the damage from: Fighting types.\n");
        }

        public static void poisonIce()
        {
            Console.WriteLine("A Poison / Ice type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Ground, Rock, Steel, Fire and Psychic types.");
            Console.WriteLine("\tHalf damage from: Poison, Bug, Grass, Ice and Fairy types.\n");
        }

        public static void poisonDragon()
        {
            Console.WriteLine("A Poison / Dragon type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Ground, Psychic, Ice and Dragon types.");
            Console.WriteLine("\tHalf damage from: Fighting, Poison, Bug, Fire, Water and Electric types.");
            Console.WriteLine("\tFourth the damage from: Grass types.\n");
        }

        public static void poisonDark()
        {
            Console.WriteLine("A Poison / Dragon type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Ground types.");
            Console.WriteLine("\tHalf damage from: Poison, Ghost, Grass and Dark types.");
            Console.WriteLine("\tIs immune to: Psychic types.\n");
        }

        public static void poisonFairy()
        {
            Console.WriteLine("A Poison / Fairy type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Ground, Steel and Psychic types.");
            Console.WriteLine("\tHalf damage from: Grass, Dark and Fairy types.");
            Console.WriteLine("\tFourth the damage from: Fighting and Bug types.");
            Console.WriteLine("\tIs immune to: Dragon types.\n");
        }
    }
}
