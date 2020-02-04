using System;


namespace _2DArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] array2d = new string[3, 5];

            for (int i = 0; i < array2d.GetLength(0); i++)
            {
                for (int j = 0; j < array2d.GetLength(1); j++)
                {
                    array2d[i, j] = i + j.ToString();
                }
            }

            for (int i = 0; i < array2d.GetLength(0); i++)
            {
                for (int j = 0; j < array2d.GetLength(1); j++)
                {
                    Console.WriteLine(array2d[i, j]);
                }
            }
            Console.ReadKey();
        }
    }
}
