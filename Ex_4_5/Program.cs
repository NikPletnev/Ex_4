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
                array[index] = rnd.Next(10);
                Console.Write(array[index] + "\t");
            }
            int sumOdd = 0;
            for (int index = 0; index < N; index++)
            {
                if(index % 2 != 0)
                {
                    sumOdd += array[index];
                }
            }
            Console.WriteLine($"Cумма элементов массива с нечетными индексами: {sumOdd}");
        }
    }
}
