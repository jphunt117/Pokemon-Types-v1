using System;


namespace PokemonType
{
    class waterType
    {
        public static void water()
        {
            Console.WriteLine("A pure Water type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Grass and Electric types.");
            Console.WriteLine("\tHalf damage from: Steel, Fire, Water and Ice types.\n");
        }

        public static void waterNormal()
        {
            Console.WriteLine("A Water / Normal type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Fighting, Grass and Electric types.");
            Console.WriteLine("\tHalf damage from: Steel, Fire, Water and Ice types.");
            Console.WriteLine("\tIs immune to: Ghost types.\n");
        }

        public static void waterFighting()
        {
            Console.WriteLine("A Water / Fighting type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Flying, Grass, Electric, Psychic and Fairy types.");
            Console.WriteLine("\tHalf damage from: Rock, Bug, Steel, Fire, Water, Ice and Dark types.\n");
        }

        public static void waterFlying()
        {
            Console.WriteLine("A Water / Flying type pokemon takes:\n");
            Console.WriteLine("\t4x damage from: Electric types.");
            Console.WriteLine("\t2x damage from: Rock types.");
            Console.WriteLine("\tHalf damage from: Fighting, Bug, Steel, Fire and Water types.");
            Console.WriteLine("\tIs immune to: Ground types.\n");
        }

        public static void waterPoison()
        {
            Console.WriteLine("A Water / Poison type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Ground, Electric and Psychic types.");
            Console.WriteLine("\tHalf damage from: Fighting, Poison, Bug, Steel, Fire, Water");
            Console.WriteLine("\tIce and Fairy types./n");
        }

        public static void waterGround()
        {
            Console.WriteLine("A Water / Ground type pokemon takes:\n");
            Console.WriteLine("\t4x damage from: Grass types.");
            Console.WriteLine("\tHalf damage from: Poison, Rock, Steel and Fire types.");
            Console.WriteLine("\tIs immune to: Electric types.\n");
        }

        public static void waterRock()
        {
            Console.WriteLine("A Water / Rock type pokemon takes:\n");
            Console.WriteLine("\t4x damage from: Grass types.");
            Console.WriteLine("\t2x damage from: Fighting, Ground and Electric types.");
            Console.WriteLine("\tHalf damage from: Normal, Flying, Poison and Ice types.");
            Console.WriteLine("\tFourth the damage from: Fire types.\n");
        }

        public static void waterBug()
        {
            Console.WriteLine("A Water / Bug type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Flying, Rock and Electric types.");
            Console.WriteLine("\tHalf damage from: Fighting, Ground, Steel, Water and Ice types.\n");
        }

        public static void waterGhost()
        {
            Console.WriteLine("A Water / Ghost type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Ghost, Grass, Electric and Dark types.");
            Console.WriteLine("\tHalf damage from: Poison, Bug, Steel, Fire, Water and Ice types.");
            Console.WriteLine("\tIs immune to: Normal and Fighting types.\n");
        }

        public static void waterSteel()
        {
            Console.WriteLine("A Water / Steel type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Fighting, Ground and Electric types.");
            Console.WriteLine("\tHalf damage from: Normal, Flying, Rock, Bug, Water, Psychic");
            Console.WriteLine("\tDragon and Fairy types.");
            Console.WriteLine("\tFourth the damage from: Steel and Ice types.");
            Console.WriteLine("\tIs immune to: Poison types.\n");
        }

        public static void waterFire()
        {
            Console.WriteLine("A Water / Fire type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Ground, Rock and Electric types.");
            Console.WriteLine("\tHalf damage from: Bug and Fairy types.");
            Console.WriteLine("\tFourth the damage from: Steel, Fire and Ice types.\n");
        }

        public static void waterGrass()
        {
            Console.WriteLine("A Water / Grass type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Flying, Poison and Bug types.");
            Console.WriteLine("\tHalf damage from: Ground and Steel types.");
            Console.WriteLine("\tFourth the damage from: Water types.\n");
        }

        public static void waterElectric()
        {
            Console.WriteLine("A Water / Electric type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Ground and Grass types.");
            Console.WriteLine("\tHalf damage from: Flying, Fire, Water and Ice types.");
            Console.WriteLine("\tFourth the damage from: Steel types.\n");
        }

        public static void waterPsychic()
        {
            Console.WriteLine("A Water / Psychic type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Bug, Ghost, Grass, Electric and Dark types.");
            Console.WriteLine("\tHalf damage from: Fighting, Steel, Fire, Water, Psychic and Ice types.\n");
        }

        public static void waterIce()
        {
            Console.WriteLine("A Water / Ice type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Fighting, Rock, Grass and Electric types.");
            Console.WriteLine("\tHalf damage from: Water types.");
            Console.WriteLine("\tFourth the damage from: Ice types.\n");
        }

        public static void waterDragon()
        {
            Console.WriteLine("A Water / Dragon type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Dragon and Fairy types.");
            Console.WriteLine("\tHalf damage from: Steel types.");
            Console.WriteLine("\tFourth the damage from: Fire and Water types.\n");
        }

        public static void waterDark()
        {
            Console.WriteLine("A Water / Dark type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Fighting, Bug, Grass, Electric and Fairy types.");
            Console.WriteLine("\tHalf damage from: Ghost, Steel, Fire, Water, Ice and Dark types.");
            Console.WriteLine("\tIs immune to: Psychic types.\n");
        }

        public static void waterFairy()
        {
            Console.WriteLine("A Water / Fairy type pokemon takes:\n");
            Console.WriteLine("\t2x damage from: Poison, Grass and Electric types.");
            Console.WriteLine("\tHalf damage from: Fighting, Bug, Fire, Water, Ice and Dark types.");
            Console.WriteLine("\tIs immune to: Dragon types.\n");
        }
    }
}
