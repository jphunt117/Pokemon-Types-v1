using System;

namespace PokemonType
{
    class rockType
    {
        public static void rock()
        {
            Console.WriteLine("A pure Rock type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Fighting, Ground, Steel, Water and Grass types.");
            Console.WriteLine("\tHalf damage from: Normal, Flying, Poison and Fire types.\n");
        }

        public static void rockNormal()
        {
            Console.WriteLine("A Rock / Normal type pokemon takes:\n");
            Console.WriteLine("\t4x damage from: Fighting types.");
            Console.WriteLine("\t2x damage from: Ground, Steel, Water and Grass types.");
            Console.WriteLine("\tHalf damage from: Normal, Flying, Poison and Fire types.");
            Console.WriteLine("\tIs immune to: Ghost types.\n");
        }

        public static void rockFighting()
        {
            Console.WriteLine("A Rock / Fighting type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Fighting, Ground, Steel, Water, Grass, Psychic and Fairy types.");
            Console.WriteLine("\tHalf damage from: Normal, Poison, Rock, Bug, Fire and Dark types.\n");
        }

        public static void rockFlying()
        {
            Console.WriteLine("A Rock / Flying type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Rock, Steel, Water, Electric and Ice types.");
            Console.WriteLine("\tHalf damage from: Normal, Flying, Poison, Bug and Fire types.");
            Console.WriteLine("\tIs immune to: Ground types.\n");
        }

        public static void rockPoison()
        {
            Console.WriteLine("A Rock / Poison type pokemon takes:\n");
            Console.WriteLine("\t4x damage from: Ground types.");
            Console.WriteLine("\t2x damage from: Steel, Water and Psychic types.");
            Console.WriteLine("\tHalf damage from: Normal, Flying, Bug, Fire and Fairy types.");
            Console.WriteLine("\tFourth the damage from: Poison types.\n");
        }

        public static void rockGround()
        {
            Console.WriteLine("A Rock / Ground type pokemon takes:\n");
            Console.WriteLine("\t4x damage from: Water and Grass types.");
            Console.WriteLine("\t2x damage from: Fighting, Ground, Steel and Ice types.");
            Console.WriteLine("\tHalf damage from: Normal, Flying, Rock and Fire types.");
            Console.WriteLine("\tFourth the damage from: Poison types.");
            Console.WriteLine("\tIs immune to: Electric types.\n");
        }

        public static void rockBug()
        {
            Console.WriteLine("A Rock / Bug type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Rock, Steel and Water types.");
            Console.WriteLine("\tHalf damage from: Normal and Poison types.\n");
        }

        public static void rockGhost()
        {
            Console.WriteLine("A Rock / Ghost type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Ground, Ghost, Steel, Water, Grass and Dark types.");
            Console.WriteLine("\tHalf damage from: Flying, Bug and Fire types.");
            Console.WriteLine("\tFourth the damage from: Poison types.");
            Console.WriteLine("\tIs immune to: Normal and Fighting types.\n");
        }

        public static void rockSteel()
        {
            Console.WriteLine("A Rock / Steel type pokemon takes:\n");
            Console.WriteLine("\t4x damage from: Fighting and Ground types.");
            Console.WriteLine("\t2x damage from: Water types.");
            Console.WriteLine("\tHalf damage from: Rock, Bug, Psychic, Ice, Dragon and Fairy types.");
            Console.WriteLine("\tFourth the damage from: Normal and Flying types.");
            Console.WriteLine("\tIs immune to: Poison types.\n");
        }

        public static void rockFire()
        {
            Console.WriteLine("A Rock / Fire type pokemon takes:\n");
            Console.WriteLine("\t4x damage from: Ground and Water types.");
            Console.WriteLine("\t2x damage from: Fighting and Rock types.");
            Console.WriteLine("\tHalf damage from: Normal, Flying, Poison, Bug, Ice and Fairy types.");
            Console.WriteLine("\tFourth the damage from: Fire types.\n");
        }

        public static void rockWater()
        {
            Console.WriteLine("A Rock / Water type pokemon takes:\n");
            Console.WriteLine("\t4x damage from: Grass types.");
            Console.WriteLine("\t2x damage from: Fighting, Ground and Electric types.");
            Console.WriteLine("\tHalf damage from: Normal, Flying, Poison and Ice types.");
            Console.WriteLine("\tFourth the damage from: Fire types.\n");
        }

        public static void rockGrass()
        {
            Console.WriteLine("A Rock / Grass type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Fighting, Bug, Steel and Ice types.");
            Console.WriteLine("\tHalf damage from: Normal and Electric types.\n");
        }

        public static void rockElectric()
        {
            Console.WriteLine("A Rock / Electric type pokemon takes:\n");
            Console.WriteLine("\t4x damage from: Ground types.");
            Console.WriteLine("\t2x damage from: Fighting, Water and Grass types.");
            Console.WriteLine("\tHalf damage from: Normal, Poison, Fire and Electric types.");
            Console.WriteLine("\tFourth the damage from: Flying types.\n");
        }

        public static void rockPsychic()
        {
            Console.WriteLine("A Rock / Psychic type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Ground, Bug, Ghost, Steel, Water, Grass and Dark types.");
            Console.WriteLine("\tHalf damage from: Normal, Flying, Poison, Fire and Psychic types.\n");
        }

        public static void rockIce()
        {
            Console.WriteLine("A Rock / Ice type pokemon takes:\n");
            Console.WriteLine("\t4x damage from: Fighting and Steel types.");
            Console.WriteLine("\t2x damage from: Ground, Rock, Water and Grass types.");
            Console.WriteLine("\tHalf damage from: Normal, Flying, Poison and Ice types.");
        }

        public static void rockDragon()
        {
            Console.WriteLine("A Rock / Dragon type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Fighting, Ground, Steel, Ice, Dragon and Fairy types.");
            Console.WriteLine("\tHalf damage from: Normal, Flying, Poison and Electric types.");
            Console.WriteLine("\tFourth the damage from: Fire types.\n");
        }

        public static void rockDark()
        {
            Console.WriteLine("A Rock / Dark type pokemon takes:\n");
            Console.WriteLine("\t4x damage from: Fighting types.");
            Console.WriteLine("\t2x damage from: Ground, Bug, Steel, Water, Grass and Fairy types.");
            Console.WriteLine("\tHalf damage from: Normal, Flying, Poison, Ghost, Fire and Dark types.");
            Console.WriteLine("\tIs immune to: Psychic types.\n");
        }

        public static void rockFairy()
        {
            Console.WriteLine("A Rock / Fairy type pokemon takes:\n");
            Console.WriteLine("\t4x damage from: Steel types.");
            Console.WriteLine("\t2x damage from: Ground, Water and Grass types.");
            Console.WriteLine("\tHalf damage from: Normal, Flying, Bug, Fire and Dark types.");
            Console.WriteLine("\tIs immune to: Dragon types.\n");
        }
            
    }
}
