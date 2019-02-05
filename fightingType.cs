using System;

namespace PokemonType
{
    class fightingType
    {
        public static void fighting()
        {
            Console.WriteLine("A pure Fighting type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Flying, Psychic and Fairy types.");
            Console.WriteLine("\tHalf damage from: Rock, Bug and Dark types.\n");
        }

        public static void fightingNormal()
        {
            Console.WriteLine("A Fighting / Normal type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Fighting, Flying, Psychic and Fairy types.");
            Console.WriteLine("\tHalf damage from: Rock, Bug and Dark types.");
            Console.WriteLine("\tIs immune to: Ghost types.\n");
        }

        public static void fightingFlying()
        {
            Console.WriteLine("A Fighting / Flying type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Flying, Electric, Psychic, Ice and Fairy types.");
            Console.WriteLine("\tHalf damage from: Fighting, Grass and Dark types.");
            Console.WriteLine("\tFourth the damage from: Bug types.");
            Console.WriteLine("\tIs immune to: Ground types.\n");
        }

        public static void fightingPoison()
        {
            Console.WriteLine("A Fighting / Poison type pokemon takes:\n");
            Console.WriteLine("\t4x damage from: Psychic types.");
            Console.WriteLine("\t2x damage from: Flying and Ground types.");
            Console.WriteLine("\tHalf damage from: Fighting, Poison, Rock, Grass and Dark types.");
            Console.WriteLine("\tFourth the damage from: Bug types.\n");
        }

        public static void fightingGround()
        {
            Console.WriteLine("A Fighting / Ground type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Flying, Water, Grass, Psychic, Ice and Fairy types.");
            Console.WriteLine("\tHalf damage from: Poison, Bug and Dark types.");
            Console.WriteLine("\tFourth the damage from: Rock types.");
            Console.WriteLine("\tIs immune to: Electric types.\n");
        }

        public static void fightingRock()
        {
            Console.WriteLine("A Fighting / Rock type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Fighting, Ground, Steel, Water, Grass, Psychic and Fairy types.");
            Console.WriteLine("\tHalf damage from: Normal, Poison, Rock, Bug, Fire and Dark types.\n");
        }

        public static void fightingBug()
        {
            Console.WriteLine("A Fighting / Bug type pokemon takes:\n");
            Console.WriteLine("\t4x damage from: Flying types.");
            Console.WriteLine("\t2x damage from: Fire, Psychic and Fairy types.");
            Console.WriteLine("\tHalf damage from: Fighting, Ground, Bug, Grass and Dark types.\n");
        }

        public static void fightingGhost()
        {
            Console.WriteLine("A Fighting / Ghost type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Flying, Ghost, Psychic and Fairy types.");
            Console.WriteLine("\tHalf damage from: Poison and Rock types.");
            Console.WriteLine("\tFourth the damage from: Bug types.");
            Console.WriteLine("\tIs immune to: Normal and Fighting types.\n");
        }

        public static void fightingSteel()
        {
            Console.WriteLine("A Fighting / Steel type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Fighting, Ground and Fire types.");
            Console.WriteLine("\tHalf damage from: Normal, Steel, Grass, Ice, Dragon and Dark types.");
            Console.WriteLine("\tFourth the damage from: Rock and Bug types.");
            Console.WriteLine("\tIs immune to: Poison types.\n");
        }

        public static void fightingFire()
        {
            Console.WriteLine("A Fire / Fighting type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Flying, Ground, Water and Psychic types.");
            Console.WriteLine("\tHalf damage from: Steel, Fire, Grass, Ice and Dark types.");
            Console.WriteLine("\tFourth the damage from: Bug types.\n");
        }

        public static void fightingWater()
        {
            Console.WriteLine("A Fighting / Water type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Flying, Grass, Electric, Psychic and Fairy types.");
            Console.WriteLine("\tHalf damage from: Rock, Bug, Steel, Fire, Water, Ice and Dark types.\n");
        }

        public static void fightingGrass()
        {
            Console.WriteLine("A Fighting / Grass type pokemon takes:\n");
            Console.WriteLine("\t4x damage from: Flying types.");
            Console.WriteLine("\t2x damage from: Poison, Fire, Psychic, Ice and Fairy types.");
            Console.WriteLine("\tHalf damage from: Ground, Rock, Water, Grass, Electric and Dark types.\n");
        }

        public static void fightingElectric()
        {
            Console.WriteLine("A Fighting / Electric type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Ground, Psychic and Fairy types.");
            Console.WriteLine("\tHalf damage from: Rock, Bug, Steel, Electric and Dark types.\n");
        }

        public static void fightingPsychic()
        {
            Console.WriteLine("A Fighting / Psychic type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Flying, Ghost and Fairy types.");
            Console.WriteLine("\tHalf damage from: Fighting and Rock types.\n");
        }

        public static void fightingIce()
        {
            Console.WriteLine("A Fighting / Ice type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Fighting, Flying, Steel, Fire, Psychic and Fairy types.");
            Console.WriteLine("\tHalf damage from: Bug, Ice and Dark types.\n");
        }

        public static void fightingDragon()
        {
            Console.WriteLine("A Fighting / Dragon type pokemon takes:\n");
            Console.WriteLine("\t4x damage from: Fairy types.");
            Console.WriteLine("\t2x damage from: Flying, Psychic, Ice and Dragon types.");
            Console.WriteLine("\tHalf damage from: Rock, Bug, Fire, Water, Grass, Electric and Dark types.\n");
        }

        public static void fightingDark()
        {
            Console.WriteLine("A Fighting / Dark type pokemon takes:\n");
            Console.WriteLine("\t4x damage from: Fairy types.");
            Console.WriteLine("\t2x damage from: Fighting and Flying types.");
            Console.WriteLine("\tHalf damage from: Rock and Ghost types.");
            Console.WriteLine("\tFourth the damage from: Dark types.");
            Console.WriteLine("\tIs immune to: Psychic types.\n");
        }

        public static void fightingFairy()
        {
            Console.WriteLine("A Fighting / Fairy type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Flying, Poison, Steel, Psychic and Fairy types.");
            Console.WriteLine("\tHalf damage from: Fighting and Rock types.");
            Console.WriteLine("\tFourth the damage from: Bug and Dark types.");
            Console.WriteLine("\tIs immune to: Dragon types.\n");
        }
    }
}
