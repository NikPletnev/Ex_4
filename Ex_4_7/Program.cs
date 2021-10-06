using System;

namespace Ex_4_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество элементов массива: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[N];
            int oddCount = 0;
            Random rnd = new Random();
            Console.WriteLine("Массив: \n");
            for (int index = 0; index < N; index++)
            {
                array[index] = rnd.Next(10);
                if(array[index]%2 != 0)
                {
                    oddCount++;
                }
                Console.Write(array[index] + "\t");
            }
            Console.WriteLine($"Количество нечетных элементов массива: {oddCount}");
        }
    }
}
