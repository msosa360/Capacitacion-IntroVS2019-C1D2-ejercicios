using System;

namespace Ejercicio_2
{
    class Program
    {
        static void buscarMultiplos()
        {
            for (int i = 0; i < 100; i++)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine("DIVISIBLE POR 5");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("DIVISIBLE POR 3");
                }
                if (i % 15 == 0)
                {
                    Console.WriteLine("DIVISIBLE POR 15");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void Main(string[] args)
        {
            buscarMultiplos();
        }
    }
}
