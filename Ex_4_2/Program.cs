using System;

namespace Ex_4_1
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
                array[index] = rnd.Next(100);
                Console.Write(array[index] + "\t");
            }
            int min = array[0];
            for (int index = 0; index < N; index++)
            {
                if (array[index] < min)
                {
                    min = array[index];
                }
            }
            Console.WriteLine($"Минимальное число в массиве: {min}");
        }
    }
}
