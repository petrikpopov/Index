using System;

namespace Indexator10._02._2022Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;

            IndexMatrix matrix = new IndexMatrix(3, 4);
            for (int i = 0; i < matrix.Count_Line; i++)
            {
                for (int j = 0; j < matrix.Count_Column; j++)
                {
                    try
                    {
                        matrix[i, j] = i + j;
                        Console.WriteLine(matrix[i, j] + "\t");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }

                }            



            }
            Console.WriteLine();




        }






    }

}


