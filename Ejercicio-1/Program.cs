using System;

namespace Ejercicio_1
{
    class Program
    {
        static int buscarMinimo(int[] arr)
        {
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                int actual = arr[i];
                if (min > actual)
                {
                    min = actual;
                }
            }
            return min;
        }

        static void Main(string[] args)
        {
            int[] numeros = { 1, 8, 20, 2, 3 };
            int min = buscarMinimo(numeros);
            Console.WriteLine(min);
        }
    }
}
