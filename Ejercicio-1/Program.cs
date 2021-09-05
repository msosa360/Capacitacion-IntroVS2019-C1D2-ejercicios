namespace Ejercicio_1
{
    class Program
    {
        static int buscarMinimo(int[] arr)
        {
            int min = arr[1];
            for (int i = 1; i < arr.Length; i++)
            {
                int actual = arr[i + 1];
                if (min < actual)
                {
                    min = actual;
                }
            }
            return min;
        }

        static void Main(string[] args)
        {
            int[] numeros = { 1, 8, 20, 2, 3 };
            integer min = buscarMinimo(numeros);
            Console.WriteLine(min);
        }
    }
}