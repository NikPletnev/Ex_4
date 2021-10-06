using System;

namespace Ex_4_8
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
            int buffer;
            for(int index = 0; index < N/2; index++)
            {
                buffer = array[index];
                array[index] = array[N / 2 + index + N % 2];
                array[N / 2 + index + N % 2] = buffer;
            }
            Console.WriteLine("\nНовый массив: \n");
            for (int index = 0; index < N; index++)
            {
                Console.Write(array[index] + "\t");
            }
        }
    }
}
