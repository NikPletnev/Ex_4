using System;

namespace Ex_4_9
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
            for (int index = 0; index < N - 1; index++)
            {
                for(int indexSup = index + 1; indexSup < N; indexSup++)
                {
                  if(array[index] > array[indexSup])
                    {
                        buffer = array[index];
                        array[index] = array[indexSup];
                        array[indexSup] = buffer;
                    }
                }
            }
            Console.WriteLine("\nСортированый массив: \n");
            for (int index = 0; index < N; index++)
            {
                Console.Write(array[index] + "\t");
            }
        }
    }
}
