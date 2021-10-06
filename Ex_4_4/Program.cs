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
            int maxIndex = 0;
            int max = array[0];
            for (int index = 0; index < N; index++)
            {
                if (array[index] > max)
                {
                    max = array[index];
                    maxIndex = index;
                }
            }
            Console.WriteLine($"Индекс максимального числа в массиве: {maxIndex}");
        }
    }
}
