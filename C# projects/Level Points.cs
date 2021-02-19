using System;
using System.Collections.Generic;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int Levels = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Points(Levels));
        }

        static int Points(int Levels)
        {
            if (Levels == 1)
                return 1;
            return Levels + Points(Levels - 1);
        }
    }
}