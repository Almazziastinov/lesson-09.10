using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodichka
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] vowels = "АЕЁИОУЫЭЮЯ".ToLower().ToCharArray(); //Гласные
            char[] consonants = "БВГДЖЗЙКЛМНПРСТФХЦЧШЩЬЪ".ToLower().ToCharArray(); //Согласные

            string str = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЬЫЪЭЮЯ";
            char[] array = str.ToLower().ToCharArray();

            int vowelsCount = GetCount(array, vowels);
            int consonantsCount = GetCount(array, consonants);

            Console.WriteLine("Гласных в массиве: " + vowelsCount);
            Console.WriteLine("Согласных в массиве: " + consonantsCount);
            Console.ReadKey();




            Console.WriteLine("Задпние 6.2");
            Console.WriteLine("Программа для умножения матриц");

            int[,] a = GetMatrixFromConsole("A");
            int[,] b = GetMatrixFromConsole("B");

            Console.WriteLine("Матрица A:");
            PrintMatrix(a);

            Console.WriteLine("Матрица B:");
            PrintMatrix(b);

            var result = MatrixMultiplication(a, b);
            Console.WriteLine("Произведение матриц:");
            PrintMatrix(result);

            Console.ReadLine();


            Console.WriteLine("Задание 6.3");
            int[,] vallue = TemprichValMatrix("A");
            Console.WriteLine("Год матрица ");
            PrintMatrix(vallue);
            int[] avtemp = AverageTemprichMass(vallue);
            for (int i = 0; i < avtemp.Length; i++)
            {
                Console.WriteLine(avtemp[i]);
            }
            Console.ReadKey();

            Console.WriteLine("DZ 61");
            var bukvyglasn = new List<string>()
            {
                "уеыаоэяи"
            };

        }

        static Random Rand(Random a)
        {
            a = new Random();
            return a;
        }
        static int[,] TemprichValMatrix(string a)
        {
            Random rnd = new Random();
            int[,] mounth = new int[3, 3];
            for (int i = 0; i < mounth.GetLength(0); i++)
            {
                for (int j = 0; j < mounth.GetLength(1); j++)
                {
                    mounth[i,j] = rnd.Next(-30, 30);
                }
            }

            return mounth;
        }
        static int[] AverageTemprichMass(int[,] matrix)
        {
            int[] month = new int[matrix.GetLength(0)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    month[i] += matrix[i, j];
                }
            }
            return month;
        }

        static int[,] GetMatrixFromConsole(string name)
        {
            Console.Write("Количество строк матрицы {0}:    ", name);
            int n = int.Parse(Console.ReadLine());
            Console.Write("Количество столбцов матрицы {0}: ", name);
            int m = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            var matrix = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0}[{1},{2}] = ", name, i, j);
                    matrix[i, j] = rnd.Next(50);
                    Console.Write(matrix[i, j] + "\n");
                
                }
            }

            return matrix;
        }
        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j].ToString() + "  ");
                }

                Console.WriteLine();
            }
        }
        static int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
        {
            if (matrixA.GetLength(0) != matrixB.GetLength(1))
            {
                throw new Exception("Умножение не возможно! Количество столбцов первой матрицы не равно количеству строк второй матрицы.");
            }

            int[,] matrixC = new int[matrixA.GetLength(1), matrixB.GetLength(0)];

            for (int i = 0; i < matrixA.GetLength(1); i++)
            {
                for (int j = 0; j < matrixB.GetLength(0); j++)
                {
                    matrixC[i, j] = 0;

                    for (int k = 0; k < matrixA.GetLength(0); k++)
                    {
                        matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
                    }
                }
            }

            return matrixC;
        }

        static int GetCount(char[] array, char[] ar)
        {
            int Count = 0;

            foreach (char ch in array)
                foreach (char cha in ar)
                    if (ch == cha)
                        Count++;

            return Count;

        }
        
    }
    

}
