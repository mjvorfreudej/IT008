using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Bai03
{
    internal class Program
    {
        // (a) Nhập / xuất ma trận hai chiều
        static void InputMatrix(int[,] a)
        {
            Console.WriteLine("Nhập các phần tử của ma trận:");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"a[{i},{j}] = ");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        static void PrintMatrix(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                    Console.Write($"{a[i, j],6}");
                Console.WriteLine();
            }    
        }

        // (b) Tìm kiếm một phần tử
        static void FindElement(int[,] a)
        {
            Console.Write("\nNhập giá trị cần tìm: ");
            int x = int.Parse(Console.ReadLine());
            bool found = false;

            Console.WriteLine($"\nCác vị trí có giá trị {x}:");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] == x)
                    {
                        Console.WriteLine($"a[{i},{j}]");
                        found = true;
                    }
                }
            }

            if (!found)
                Console.WriteLine($"Không tìm thấy {x} trong ma trận.");
        }

        // (c) Xuất các phần tử là số nguyên tố
        static bool IsPrime(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i * i <= n; i++)
                if (n % i == 0) return false;
            return true;
        }

        static bool IsDuplicateBefore(int[,] a, int row, int col, int value)
        {
            for (int i = 0; i <= row; i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (i == row && j >= col) break;
                    if (a[i, j] == value) return true;
                }
            }
            return false;
        }

        static void PrintPrimes(int[,] a)
        {
            Console.WriteLine("\nCác phần tử là số nguyên tố:");
            bool foundPrimes = false;

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    int value = a[i, j];
                    if (IsPrime(value) && !IsDuplicateBefore(a, i, j, value))
                    {
                        Console.WriteLine($"{value}");
                        foundPrimes = true;
                    }
                }
            }

            if (!foundPrimes)
                Console.WriteLine("Không có số nguyên tố nào trong ma trận.");
            else
                Console.WriteLine();
        }

        // (d) Dòng có nhiều số nguyên tố nhất
        static void PrintRowWithMostPrimes(int[,] a)
        {
            int bestRow = -1;
            int maxCount = 0;

            for (int i = 0; i < a.GetLength(0); i++)
            {
                int count = 0;
                for (int j = 0; j < a.GetLength(1); j++)
                    if (IsPrime(a[i, j])) count++;
                if (count > maxCount)
                {
                    maxCount = count;
                    bestRow = i;
                }
            }

            if (maxCount == 0)
                Console.WriteLine("\nKhông có dòng nào chứa số nguyên tố.");
            else
                Console.WriteLine($"Dòng có nhiều số nguyên tố nhất: dòng {bestRow}");
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập số dòng: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Nhập số cột: ");
            int n = int.Parse(Console.ReadLine());
            int[,] a = new int[m, n];

            InputMatrix(a);
            Console.WriteLine("\nMa trận vừa nhập:");
            PrintMatrix(a);
            FindElement(a);
            PrintPrimes(a);
            PrintRowWithMostPrimes(a);
        }
    }
}
