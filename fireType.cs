using System;

namespace PokemonType
{
    class fireType
    {
        public static void fire()
        {
            Console.WriteLine("A pure fire type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Water, Ground and Rock types.");
            Console.WriteLine("\tHalf damage from: Fire, Grass, Ice, Bug, Steel and Fairy types.\n");
        }

        public static void fireNormal()
        {
            Console.WriteLine("A Fire / Normal type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Water, Fighting, Ground and Rock types.");
            Console.WriteLine("\tHalf damage from: Fire, Grass, Ice, Bug, Steel and Fairy tpes.");
            Console.WriteLine("\tIs immune to: Ghost type.\n");
        }

        public static void fireWater()
        {
            Console.WriteLine("A Fire / Water type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Electric, Ground and Rock types.");
            Console.WriteLine("\tHalf damage from: Bug and Fairy types.");
            Console.WriteLine("\tFourth the damage from: Fire, Ice and Steel types.");
        }

        public static void fireElectric()
        {
            Console.WriteLine("A Fire / Electric type pokemon takes:\n");
            Console.WriteLine("\t4x damage from: Ground types.");
            Console.WriteLine("\t2x damage from: Water and Rock types.");
            Console.WriteLine("\tHalf damage from: Fire, Electric, Grass, Ice, Flying, Bug and Fairy types.");
            Console.WriteLine("\tFourth the damage from: Steel types.\n");
        }

        public static void fireGrass()
        {
            Console.WriteLine("A Fire / Grass type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Flying, Poison and Rock");
            Console.WriteLine("\tHalf damage from: Steel, Electric and Fairy types.");
            Console.WriteLine("\tFourth the damage from: Grass types.\n");
        }

        public static void fireIce()
        {
            Console.WriteLine("A Fire / Ice type pokemon takes:\n");
            Console.WriteLine("\t4x damage from: Rock types.");
            Console.WriteLine("\t2x damage from: Fighting, Ground and Water types.");
            Console.WriteLine("\tHalf damage from: Bug, Grass and Fairy types.");
            Console.WriteLine("\tFourth the damage from: Ice types.\n");
        }

        public static void fireFighting()
        {
            Console.WriteLine("A Fire / Fighting type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Water, Ground, Flying and Psychic types.");
            Console.WriteLine("\tHalf damage from: Fire, Grass, Ice, Dark and Steel types.");
            Console.WriteLine("\tFourth the damage from: Bug types.\n");
        }

        public static void firePoison()
        {
            Console.WriteLine("A Fire / Poison type pokemon takes:\n");
            Console.WriteLine("\t4x damage from: Ground types.");
            Console.WriteLine("\t2x damage from: Water, Psychic and Rock types.");
            Console.WriteLine("\tHalf damage from: Fire, Ice, Fighting, Poison and Steel types.");
            Console.WriteLine("\tFourth the damage from: Grass, Bug and Fairy types.\n");
        }

        public static void fireGround()
        {
            Console.WriteLine("A Fire / Ground type pokemon takes:\n");
            Console.WriteLine("\t4x damage from: Water types.");
            Console.WriteLine("\t2x damage from: Ground types.");
            Console.WriteLine("\tHalf damage from: Fire, Poison, Bug, Steel and Fairy types.");
            Console.WriteLine("\tIs immune to: Electric types.\n");
        }

        public static void fireFlying()
        {
            Console.WriteLine("A Fire / Flying type pokemon takes:\n");
            Console.WriteLine("\t4x damage from: Rock types.");
            Console.WriteLine("\t2x damage from: Water and Electric types.");
            Console.WriteLine("\tHalf damage from: Fire, Fighting, Steel and Fairy types.");
            Console.WriteLine("\tFourth the damage from: Grass and Bug types.");
            Console.WriteLine("\tIs immune to: Ground types.\n");
        }

        public static void firePsychic()
        {
            Console.WriteLine("A Fire / Psychic type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Water, Ground, Rock, Ghost and Dark types.");
            Console.WriteLine("\tHalf damage from: Fire, Grass, Ice, Fighting, Psychic, Steel and Fairy types.\n");
        }

        public static void fireBug()
        {
            Console.WriteLine("A Fire / Bug type pokemon takes:\n");
            Console.WriteLine("\t4x damage from: Rock types.");
            Console.WriteLine("\t2x damage from: Water and Flying types.");
            Console.WriteLine("\tHalf damage from: Ice, Fighting, Bug, Steel and Fairy types.");
            Console.WriteLine("\tFourth the damage from: Grass types.\n");
        }

        public static void fireRock()
        {
            Console.WriteLine("A Fire / Rock type pokemon takes:\n");
            Console.WriteLine("\t4x damage from: Water and Ground types.");
            Console.WriteLine("\t2x damage from: Fighting and Rock types.");
            Console.WriteLine("\tHalf damage from: Normal, Ice, Poison, Flying, Bug and Fairy types.");
            Console.WriteLine("\tFourth the damage from: Fire types.\n");
        }

        public static void fireGhost()
        {
            Console.WriteLine("A Fire / Ghost type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Water, Ground, Rock, Ghost and Dark types.");
            Console.WriteLine("\tHalf damage from: Fire, Grass, Ice, Poison, Steel and Fairy types.");
            Console.WriteLine("\tFourth the damage from: Bug types.");
            Console.WriteLine("\tIs immune to: Normal and Fighting types.\n");
        }

        public static void fireDragon()
        {
            Console.WriteLine("A Fire / Dragon type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Ground, Rock and Dragon types.");
            Console.WriteLine("\tHalf damage from: Electric, Bug and Steel types.");
            Console.WriteLine("\tFourth the damage from: Fire and Ice types.\n");
        }

        public static void fireDark()
        {
            Console.WriteLine("A Fire / Dark type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Water, Fighting, Ground and Rock types.");
            Console.WriteLine("\tHalf damage from: Fire, Grass, Ice, Ghost, Dark and Steel types.");
            Console.WriteLine("\tIs immune to: Psychic types.\n");
        }

        public static void fireSteel()
        {
            Console.WriteLine("A Fire / Steel type pokemon takes:\n");
            Console.WriteLine("\t4x damage from: Ground types.");
            Console.WriteLine("\t2x damage from: Water and Fighting types.");
            Console.WriteLine("\tHalf damage from: Normal, Flying, Psychic and Dragon types.");
            Console.WriteLine("\tFourth the damage from: Grass, Ice, Bug, Steel and Fairy types.");
            Console.WriteLine("\tIs immune to: Poison types.\n");
        }

        public static void fireFairy()
        {
            Console.WriteLine("A Fire / Fairy type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Poison, Ground, Rock and Water types.");
            Console.WriteLine("\tHalf damage from: Fighting, Fire, Grass, Ice, Dark and Fairy types.");
            Console.WriteLine("\tFourth the damage from: Bug types.");
            Console.WriteLine("\tIs immune to: Dragon types.\n");
        }
    }
}
