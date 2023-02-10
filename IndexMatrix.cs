using System;

namespace Indexator10._02._2022Matrix
{
    public class IndexMatrix
    {
       
        public int Count_Line { set; get; }
        public int Count_Column { set; get; }
        private int[,] mass;

        public IndexMatrix() { }

        public IndexMatrix(int CL, int CC)
        {
            Count_Column = CC;
            Count_Line = CL;
            mass = new int[Count_Line, Count_Column];
        }

        public int this[int CL, int CC]
        {
            get
            {
                if (CL < 0 || CL > mass.GetLength(0))
                {
                    throw new Exception("Не коректный индекс:" + CL);
                }
                else if (CC < 0 || CC > mass.GetLength(1))
                {
                    throw new Exception("Не коректный индекс:" + CC);
                }
                
            }
            set
            {
                if (CL > 0 || CL < mass.GetLength(0))
                {
                    CL = value;
                }
                else if (CL > 0 || CL < mass.GetLength(1))
                {
                    CC = value;
                }
                else
                {
                    throw new Exception("Не коректный индекс:");
                }

            }
            

        }

        /*static IndexMatrix()
        {
            Console.Write("Введите кол-во строк в матрице:");
            Count_Line = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите кол-во столбцов в матрице:");
            Count_Column = Convert.ToInt32(Console.ReadLine());
        }*/

        /*public void Mass()
        {
            int Max = mass[0, 0];
            int Min = mass[0, 0];
            int j = 0;
            int i = 0;
            Random R = new Random();
            for (i = 0; i < Count_Line; i++)
            {
                for (j = 0; j < Count_Column; j++)
                {
                    mass[i, j] = R.Next(1, 30);
                    Console.Write("{0}\t", mass[i, j]);
                    if (mass[i, j] > Max)
                    {
                        Max = mass[i, j];
                    }
                    if (mass[i, j] < Min)
                    {
                        Min = mass[i, j];
                    }
                }

                Console.WriteLine();
            }
            Console.WriteLine("Максимальный элимент = " + Max);
            Console.WriteLine("Минимальный элимент = " + Min);
        }*/
    }
}   
