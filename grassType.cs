using System;

namespace PokemonType
{
    class grassType
    {
        public static void grass()
        {
            Console.WriteLine("A pure Grass type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Flying, Poison, Bug, Fire and Ice types.");
            Console.WriteLine("\tHalf damage from: Ground, Water, Grass and Electric types.\n");
        }

        public static void grassNormal()
        {
            Console.WriteLine("A Grass / Normal type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Fighting, Flying, Poison, Bug, Fire and Ice types.");
            Console.WriteLine("\tHalf damage from: Ground, Water, Grass and Electric types.");
            Console.WriteLine("\tIs immune to: Ghost types.\n");
        }

        public static void grassFighting()
        {
            Console.WriteLine("A Grass / Fighting type pokemon takes:\n");
            Console.WriteLine("\t4x damage from: Flying types.");
            Console.WriteLine("\t2x damage from: Poison, Fire, Psychic, Ice and Fairy types.");
            Console.WriteLine("\tHalf damage from: Ground, Rock, Water, Grass, Electric");
            Console.WriteLine("\tand Dark types.\n");
        }

        public static void grassFlying()
        {
            Console.WriteLine("A Grass / Flying type pokemon takes:\n");
            Console.WriteLine("\t4x damage from: Ice types.");
            Console.WriteLine("\t2x damage from: Flying, Poison, Rock and Fire types.");
            Console.WriteLine("\tHalf damage from: Fighting and Water types.");
            Console.WriteLine("\tFourth the damage from: Grass types.");
            Console.WriteLine("\tIs immune to: Ground types.\n");
        }

        public static void grassPoison()
        {
            Console.WriteLine("A Grass / Poison type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Flying, Fire, Psychic and Ice types.");
            Console.WriteLine("\tHalf damage from: Fighting, Water, Electric and Fairy types.");
            Console.WriteLine("\tFourth the damage from: Grass types.\n");
        }

        public static void grassGround()
        {
            Console.WriteLine("A Grass / Ground type pokemon takes:\n");
            Console.WriteLine("\t4x damage from: Ice types.");
            Console.WriteLine("\t2x damage from: Flying, Bug and Fire types.");
            Console.WriteLine("\tHalf damage from: Ground and Rock types.");
            Console.WriteLine("\tIs immune to: Electric types.\n");
        }

        public static void grassRock()
        {
            Console.WriteLine("A Grass / Rock type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Fighting, Bug, Steel and Ice types.");
            Console.WriteLine("\tHalf damage from: Normal and Electric types.\n");
        }

        public static void grassBug()
        {
            Console.WriteLine("A Grass / Bug type pokemon takes:\n");
            Console.WriteLine("\t4x damage from: Flying and Fire types.");
            Console.WriteLine("\t2x damage from: Poison, Rock, Bug and Ice types.");
            Console.WriteLine("\tHalf damage from: Fighting, Water and Electric types.");
            Console.WriteLine("\tFourth the damage from: Ground and Grass types.\n");
        }

        public static void grassGhost()
        {
            Console.WriteLine("A Grass / Ghost type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Flying, Ghost, Fire, Ice and Dark types.");
            Console.WriteLine("\tHalf damage from: Ground, Water, Grass and Electric types.");
            Console.WriteLine("\tIs immune to: Normal and Fighting types.\n");
        }

        public static void grassSteel()
        {
            Console.WriteLine("A Grass / Steel type pokemon takes:\n");
            Console.WriteLine("\t4x damage from: Fire types.");
            Console.WriteLine("\t2x damage from: Fighting types.");
            Console.WriteLine("\tHalf damage from: Normal, Rock, Steel, Water, Electric");
            Console.WriteLine("\tPsychic, Dragon and Fairy types.");
            Console.WriteLine("\tFourth the damage from: Grass types.");
            Console.WriteLine("\tIs immune to: Poison types.\n");
        }

        public static void grassFire()
        {
            Console.WriteLine("A Grass / Fire type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Flying, Poison and Rock types.");
            Console.WriteLine("\tHalf damage from: Steel, Electric and Fairy types.");
            Console.WriteLine("\tFourth the damage from: Grass types.\n");
        }

        public static void grassWater()
        {
            Console.WriteLine("A Grass / Water type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Flying, Poison and Bug types.");
            Console.WriteLine("\tHalf damage from: Ground and Steel types.");
            Console.WriteLine("\tFourth the damage from: Water types.\n");
        }

        public static void grassElectric()
        {
            Console.WriteLine("A Grass / Electric type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Poison, Bug, Fire and Ice types.");
            Console.WriteLine("\tHalf damage from: Steel, Water and Grass types.");
            Console.WriteLine("\tFourth the damage from: Electric types.\n");
        }

        public static void grassPsychic()
        {
            Console.WriteLine("A Grass / Psychic type pokemon takes:\n");
            Console.WriteLine("\t4x damage from: Bug types.");
            Console.WriteLine("\t2x damage from: Flying, Poison, Ghost, Fire");
            Console.WriteLine("\tIce and Dark types.");
            Console.WriteLine("\tHalf damage from: Fighting, Ground, Water, Grass");
            Console.WriteLine("\tElectric and Psychic types.\n");
        }

        public static void grassIce()
        {
            Console.WriteLine("A Grass / Ice type pokemon takes:\n");
            Console.WriteLine("\t4x damage from: Fire types.");
            Console.WriteLine("\t2x damage from: Fighting, Flying, Poison, Rock");
            Console.WriteLine("\tBug and Steel types.");
            Console.WriteLine("\tHalf damage from: Ground, Water, Grass and Electric types.\n");
        }

        public static void grassDragon()
        {
            Console.WriteLine("A Grass / Dragon type pokemon takes:\n");
            Console.WriteLine("\t4x damage from: Ice types.");
            Console.WriteLine("\t2x damage from: Flying, Poison, Bug, Dragon and Fairy types.");
            Console.WriteLine("\tHalf damage from: Ground types.");
            Console.WriteLine("\tFourth the damage from: Water, Grass and Electric types.\n");
        }

        public static void grassDark()
        {
            Console.WriteLine("A Grass / Dark type pokemon takes:\n");
            Console.WriteLine("\t4x damage from: Bug types.");
            Console.WriteLine("\t2x damage from: Fighting, Flying, Poison, Fire");
            Console.WriteLine("\tIce and Fairy types.");
            Console.WriteLine("\tHalf damage from: Ground, Ghost, Water, Grass");
            Console.WriteLine("\tElectric and Dark types.");
            Console.WriteLine("\tIs immune to: Psychic types.\n");
        }

        public static void grassFairy()
        {
            Console.WriteLine("A Grass / Fairy type pokemon takes:\n");
            Console.WriteLine("\t4x damage from: Poison types.");
            Console.WriteLine("\t2x damage from: Flying, Steel, Fire and Ice types.");
            Console.WriteLine("\tHalf damage from: Fighting, Ground, Water, Grass");
            Console.WriteLine("\tElectric and Dark types.");
            Console.WriteLine("\tIs immune to: Dragon types.\n");
        }
    }
}
