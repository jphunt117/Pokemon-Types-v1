using System;

namespace PokemonType
{
    class ghostType
    {
        public static void ghost()
        {
            Console.WriteLine("A pure Ghost type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Ghost and Dark types.");
            Console.WriteLine("\tHalf damage from: Poison and Bug types.");
            Console.WriteLine("\tIs immune to: Normal and Fighting types.\n");
        }

        public static void ghostNormal()
        {
            Console.WriteLine("A Ghost / Normal type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Dark types.");
            Console.WriteLine("\tHalf damage from: Poison and Bug types.");
            Console.WriteLine("\tIs immune to: Normal, Fighting and Ghost types.\n");
        }

        public static void ghostFighting()
        {
            Console.WriteLine("A Ghost / Fighting type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Flying, Ghost, Psychic and Fairy types.");
            Console.WriteLine("\tHalf damage from: Poison and Rock types.");
            Console.WriteLine("\tFourth the damage from: Bug types.");
            Console.WriteLine("\tIs immune to: Normal and Fighting types.\n");
        }

        public static void ghostFlying()
        {
            Console.WriteLine("A Ghost / Flying type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Rock, Ghost, Electric, Ice and Dark types.");
            Console.WriteLine("\tHalf damage from: Poison and Grass types.");
            Console.WriteLine("\tFourth the damage from: Bug types.");
            Console.WriteLine("\tIs immune to: Normal, Fighting and Ground types.\n");
        }

        public static void ghostPoison()
        {
            Console.WriteLine("A Ghost / Poison type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Ground, Ghost, Psychic and Dark types.");
            Console.WriteLine("\tHalf damage from: Grass and Fairy types.");
            Console.WriteLine("\tFourth the damage from: Poison and Bug types.");
            Console.WriteLine("\tIs immune to: Normal and Fighting types.\n");
        }

        public static void ghostGround()
        {
            Console.WriteLine("A Ghost / Ground type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Ghost, Water, Grass, Ice and Dark types.");
            Console.WriteLine("\tHalf damage from: Rock and Bug types.");
            Console.WriteLine("\tFourth the damage from: Poison types.");
            Console.WriteLine("\tIs immune to: Normal, Fighting and Electric types.\n");
        }

        public static void ghostRock()
        {
            Console.WriteLine("A Ghost / Rock type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Ground, Ghost, Steel, Water, Grass and Dark types.");
            Console.WriteLine("\tHalf damage from: Flying, Bug and Fire types.");
            Console.WriteLine("\tFourth the damage from: Poison types.");
            Console.WriteLine("\tIs immune to: Normal and Fighting types.\n");
        }

        public static void ghostBug()
        {
            Console.WriteLine("A Ghost / Bug type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Flying, Rock, Ghost, Fire and Dark types.");
            Console.WriteLine("\tHalf damage from: Poison, Ground, Bug and Grass types.");
            Console.WriteLine("\tIs immune to: Normal and Fighting types.\n");
        }

        public static void ghostSteel()
        {
            Console.WriteLine("A Ghost / Steel type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Ground, Ghost, Fire and Dark types.");
            Console.WriteLine("\tHalf damage from: Flying, Rock, Steel, Grass, Psychic, Ice");
            Console.WriteLine("\tDragon and Fairy types.");
            Console.WriteLine("\tFourth the damage from: Bug Types.");
            Console.WriteLine("\tIs immune to: Normal, Fighting and Poison types.\n");
        }

        public static void ghostFire()
        {
            Console.WriteLine("A Ghost / Fire type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Ground, Rock, Ghost, Water and Dark types.");
            Console.WriteLine("\tHalf damage from: Poison, Steel, Fire, Grass, Ice and Fairy types.");
            Console.WriteLine("\tFourth the damage from: Bug types.");
            Console.WriteLine("\tIs immune to: Normal and Fighting types.\n");
        }

        public static void ghostWater()
        {
            Console.WriteLine("A Ghost / Water type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Ghost, Grass, Electric and Dark types.");
            Console.WriteLine("\tHalf damage from: Poison, Bug, Steel, Fire, Water and Ice types.");
            Console.WriteLine("\tIs immune to: Normal and Fighting types.\n");
        }

        public static void ghostGrass()
        {
            Console.WriteLine("A Ghost / Grass type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Flying, Ghost, Fire, Ice and Dark types.");
            Console.WriteLine("\tHalf damage from: Ground, Water, Grass and Electric types.");
            Console.WriteLine("\tIs immune to: Normal and Fighting types.\n");
        }

        public static void ghostElectric()
        {
            Console.WriteLine("A Ghost / Electric type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Ground, Ghost and Dark types.");
            Console.WriteLine("\tHalf damage from: Flying, Poison, Bug, Steel and Electric types.");
            Console.WriteLine("\tIs immune to: Normal and Fighting types.\n");
        }

        public static void ghostPsychic()
        {
            Console.WriteLine("A Ghost / Psychic type pokemon takes:\n");
            Console.WriteLine("\t4x damage from: Ghost and Dark types.");
            Console.WriteLine("\tHalf damage from: Poison and Psychic types.");
            Console.WriteLine("\tIs immune to: Normal and Fighting types.\n");
        }

        public static void ghostIce()
        {
            Console.WriteLine("A Ghost / Ice type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Rock, Ghost, Steel, Fire and Dark types.");
            Console.WriteLine("\tHalf damage from: Poison, Bug and Ice types.");
            Console.WriteLine("\tIs immune to: Normal and Fighting types.\n");
        }

        public static void ghostDragon()
        {
            Console.WriteLine("A Ghost / Dragon type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Ghost, Ice, Dragon, Dark and Fairy types.");
            Console.WriteLine("\tHalf damage from: Poison, Bug, Fire, Water, Grass and Electric types.");
            Console.WriteLine("\tIs immune to: Normal and Fighting types.\n");
        }

        public static void ghostDark()
        {
            Console.WriteLine("A Ghost / Dark type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Fairy types.");
            Console.WriteLine("\tHalf damage from: Poison types.");
            Console.WriteLine("\tIs immune to: Normal, Fighting and Psychic types.\n");
        }

        public static void ghostFairy()
        {
            Console.WriteLine("A Ghost / Fairy type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Ghost and Steel types.");
            Console.WriteLine("\tFourth the damage from: Bug types.");
            Console.WriteLine("\tIs immune to: Normal, Fighting and Dragon types.\n");
        }
    }
}
