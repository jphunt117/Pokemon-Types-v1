using System;

namespace PokemonType
{
    class flyingType
    {
        public static void flying()
        {
            Console.WriteLine("A pure Flying type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Rock, Electric and Ice types.");
            Console.WriteLine("\tHalf damage from: Fighting, Bug and Grass types.");
            Console.WriteLine("\tIs immune to: Ground types.\n");
        }

        public static void flyingNormal()
        {
            Console.WriteLine("A Flying / Normal type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Rock, Electric and Ice types.");
            Console.WriteLine("\tHalf damage from: Bug and Grass types.");
            Console.WriteLine("\tIs immune to: Ground and Ghost types.\n");
        }

        public static void flyingFighting()
        {
            Console.WriteLine("A Flying / Fighting type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Flying, Electric, Psychic, Ice and Fairy types.");
            Console.WriteLine("\tHalf damage from: Fighting, Grass and Dark types.");
            Console.WriteLine("\tFourth the damage from: Bug types.");
            Console.WriteLine("\tIs immune to: Ground types.\n");
        }

        public static void flyingPoison()
        {
            Console.WriteLine("A Flying / Poison type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Rock, Electric, Psychic and Ice types.");
            Console.WriteLine("\tHalf damage from: Poison and Fairy types.");
            Console.WriteLine("\tFourth the damage from: Fighting, Bug and Grass types.");
            Console.WriteLine("\tIs immune to: Ground types.\n");
        }

        public static void flyingGround()
        {
            Console.WriteLine("A Flying / Ground type pokemon takes:\n");
            Console.WriteLine("\t4x damage from: Ice types.");
            Console.WriteLine("\t2x damage from: Water types.");
            Console.WriteLine("\tHalf damage from: Fighting, Poison and Bug types.");
            Console.WriteLine("\tIs immune to: Ground and Electric types.\n");
        }

        public static void flyingRock()
        {
            Console.WriteLine("A Flying / Rock type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Rock, Steel, Water, Electric and Ice types.");
            Console.WriteLine("\tHalf damage from: Normal, Flying, Poison, Bug and Fire types.");
            Console.WriteLine("\tIs immune to: Ground types.\n");
        }

        public static void flyingBug()
        {
            Console.WriteLine("A Flying / Bug type pokemon takes:\n");
            Console.WriteLine("\t4x damage from: Rock types.");
            Console.WriteLine("\t2x damage from: Flying, Fire, Electric and Ice types.");
            Console.WriteLine("\tHalf damage from: Bug types.");
            Console.WriteLine("\tFourth the damage from: Fighting and Grass types.");
            Console.WriteLine("\tIs immune to: Ground types.\n");
        }

        public static void flyingGhost()
        {
            Console.WriteLine("A Flying / Ghost type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Rock, Ghost, Electric, Ice and Dark types.");
            Console.WriteLine("\tHalf damage from: Poison and Grass types.");
            Console.WriteLine("\tFourth the damage from: Bug types.");
            Console.WriteLine("\tIs immune to: Normal, Fighting and Ground types.\n");
        }

        public static void flyingSteel()
        {
            Console.WriteLine("A Flying / Steel type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Fire and Electric types.");
            Console.WriteLine("\tHalf damage from: Normal, Flying, Steel, Psychic, Dragon and Fairy types.");
            Console.WriteLine("\tFourth the damage from: Bug and Grass types.");
            Console.WriteLine("\tIs immune to: Poison and Ground types.\n");
        }

        public static void flyingFire()
        {
            Console.WriteLine("A Flying / Fire type pokemon takes:\n");
            Console.WriteLine("\t4x damage from: Rock types.");
            Console.WriteLine("\t2x damage from: Water and Electric types.");
            Console.WriteLine("\tHalf damage from: Fighting, Steel, Fire and Fairy types.");
            Console.WriteLine("\tFourth the damage from: Bug and Grass types.");
            Console.WriteLine("\tIs immune to: Ground types.\n");
        }

        public static void flyingWater()
        {
            Console.WriteLine("A Flying / Water type pokemon takes:\n");
            Console.WriteLine("\t4x damage from: Electric types.");
            Console.WriteLine("\t2x damage from: Rock types.");
            Console.WriteLine("\tHalf damage from: Fighting, Bug, Steel, Fire and Water types.");
            Console.WriteLine("\tIs immune to: Ground types.\n");
        }

        public static void flyingGrass()
        {
            Console.WriteLine("A Flying / Grass type pokemon takes:\n");
            Console.WriteLine("\t4x damage from: Ice types.");
            Console.WriteLine("\t2x damage from: Flying, Poison, Rock and Fire types.");
            Console.WriteLine("\tHalf damage from: Fighting and Water types.");
            Console.WriteLine("\tFourth the damage from: Grass types.");
            Console.WriteLine("\tIs immune to: Ground types.\n");
        }

        public static void flyingElectric()
        {
            Console.WriteLine("A Flying / Electric type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Rock and Ice types.");
            Console.WriteLine("\tHalf damage from: Fighting, Flying, Bug, Steel and Grass types.");
            Console.WriteLine("\tIs immune to: Ground types.\n");
        }

        public static void flyingPsychic()
        {
            Console.WriteLine("A Flying / Psychic type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Rock, Ghost, Electric, Ice and Dark types.");
            Console.WriteLine("\tHalf damage from: Grass and Psychic types.");
            Console.WriteLine("\tFourth the damage from: Fighting types.");
            Console.WriteLine("\tIs immune to: Ground types.\n");
        }

        public static void flyingIce()
        {
            Console.WriteLine("A Flying / Ice type pokemon takes:\n");
            Console.WriteLine("\t4x damage from: Rock types.");
            Console.WriteLine("\t2x damage from: Steel, Fire and Electric types.");
            Console.WriteLine("\tHalf damage from: Bug and Grass types.");
            Console.WriteLine("\tIs immune to: Ground types.\n");
        }

        public static void flyingDragon()
        {
            Console.WriteLine("A Flying / Dragon type pokemon takes:\n");
            Console.WriteLine("\t4x damage from: Ice types.");
            Console.WriteLine("\t2x damage from: Rock, Dragon and Fairy types.");
            Console.WriteLine("\tHalf damage from: Fighting, Bug, Fire and Water types.");
            Console.WriteLine("\tFourth the damage from: Grass types.");
            Console.WriteLine("\tIs immune to: Ground types.\n");
        }

        public static void flyingDark()
        {
            Console.WriteLine("A Flying / Dark type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Rock, Electric, Ice and Fairy types.");
            Console.WriteLine("\tHalf damage from: Ghost, Grass and Dark types.");
            Console.WriteLine("\tIs immune to: Ground and Psychic types.\n");
        }

        public static void flyingFairy()
        {
            Console.WriteLine("A Flying / Fairy type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Poison, Rock, Steel, Electric and Ice types.");
            Console.WriteLine("\tHalf damage from: Grass and Dark types.");
            Console.WriteLine("\tFourth the damage from: Fighting and Bug types.");
            Console.WriteLine("\tIs immune to: Ground and Dragon types.\n");
        }
    }
}
