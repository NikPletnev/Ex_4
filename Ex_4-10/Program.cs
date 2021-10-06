using System;

namespace Ex_4_10
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
            int buffer;
            int count = 0;
            bool flag = true;
            while (flag)
            {
                flag = false;
                for (int index = 0; index < N - count - 1; index++)
                {
                    if (array[index] > array[index + 1])
                    {
                        buffer = array[index];
                        array[index] = array[index + 1];
                        array[index + 1] = buffer;
                        flag = true;
                    }
                    
                }
                count++;
            }
            Console.WriteLine("\n Сортированый массив: \n");
            for (int index = 0; index < N; index++)
            {
                Console.Write(array[index] + "\t");
            }
        }
    }
}
