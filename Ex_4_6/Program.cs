using System;

namespace Ex_4_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество элементов массива: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[N];
            Random rnd = new Random();
            Console.WriteLine("Массив: \n");
            for (int index = 0; index < N; index++)
            {
                array[index] = rnd.Next(10);
                Console.Write(array[index] + "\t");
            }

            for(int index = 0; index < N/2; index++)
            {
                int buffer = array[index];
                array[index] = array[array.Length - index - 1];
                array[array.Length - index - 1] = buffer;     
            }
            Console.WriteLine("\nРеверс массива: \n");
            for (int index = 0; index < N; index++)
            {           
                Console.Write(array[index] + "\t");
            }
        }
    }
}
