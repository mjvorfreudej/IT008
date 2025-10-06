using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai06
{
    class Program
    {
        //In ma trận
        static void PrintMatrix(int[,] matrix)
        {
            Console.WriteLine("\n1. XUAT MA TRAN");
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++) {
                for (int j = 0; j < cols; j++)
                    Console.Write(matrix[i, j] + " ");
                Console.WriteLine();
            }
        }

        //Tìm phần tử lớn nhất trong ma trận
        static int FindMax(int[,] matrix)
        {
            int max = matrix[0, 0];
            foreach (int n in matrix) {
                if (n > max)
                    max = n;
            }
            return max;
        }

        //Tìm phần tử nhỏ nhất trong ma trận
        static int FindMin(int[,] matrix)
        {
            int min = matrix[0, 0];
            foreach (int n in matrix) {
                if (n < min)
                    min = n;
            }
            return min;
        }

        //In ra phần tử lớn nhất và nhỏ nhất trong ma trận
        static void FindMaxMin(int[,] matrix)
        {
            Console.WriteLine("\n2. TIM PHAN TU LON NHAT/NHO NHAT");
            int max = FindMax(matrix);
            int min = FindMin(matrix);
            Console.WriteLine($"Phan tu lon nhat: {max}");
            Console.WriteLine($"Phan tu nho nhat: {min}");
        }

        //Tìm dòng có tổng giá trị lớn nhất trong ma trận
        static int FindRowWithMaxSum(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int maxSum = int.MinValue;
            int maxRow = 0;

            for (int i = 0; i < rows; i++)
            {
                int sum = 0;
                for (int j = 0; j < cols; j++)
                    sum += matrix[i, j];

                if (sum > maxSum) {
                    maxSum = sum;
                    maxRow = i;
                }
            }

            return maxRow;
        }

        //In ra dòng có tổng lớn nhất và giá trị tổng tương ứng
        static void PrintRowWithMaxSum(int[,] matrix)
        {
            Console.WriteLine("\n3. TIM DONG CO TONG LON NHAT");
            int dongMax = FindRowWithMaxSum(matrix);
            int cols = matrix.GetLength(1);
            int tongMax = 0;
            for (int j = 0; j < cols; j++)
                tongMax += matrix[dongMax, j];
            Console.WriteLine($"Dong co tong lon nhat: Dong {dongMax} (Tong = {tongMax})");
        }

        //Kiểm tra số nguyên tố
        static bool IsPrime(int n)
        {
            if (n < 2)
                return false;
            if (n == 2)
                return true;
            if (n % 2 == 0)
                return false;

            for (int i = 3; i * i <= n; i += 2) {
                if (n % i == 0)
                    return false;
            }
            return true;
        }

        //Tính tổng các phần tử trong ma trận không phải là số nguyên tố
        static int SumNonPrimeNums(int[,] matrix)
        {
            int sum = 0;
            foreach (int n in matrix) {
                if (!IsPrime(n))
                    sum += n;
            }
            return sum;
        }

        //In ra tổng các phần tử không phải số nguyên tố
        static void PrintSumNonPrimeNums(int[,] matrix)
        {
            Console.WriteLine("\n4. TINH TONG CAC SO KHONG PHAI LA SO NGUYEN TO");
            int tong = SumNonPrimeNums(matrix);
            Console.WriteLine($"Tong cac so khong phai nguyen to: {tong}");
        }

        //Xóa dòng thứ k trong ma trận và trả về ma trận mới
        static int[,] DeleteRow(int[,] matrix, int k)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            if (k < 0 || k >= rows) {
                Console.WriteLine("Dong k khong hop le!");
                return matrix;
            }

            int[,] newMatrix = new int[rows - 1, cols];
            int newRow = 0;

            for (int i = 0; i < rows; i++)
            {
                if (i != k) {
                    for (int j = 0; j < cols; j++)
                        newMatrix[newRow, j] = matrix[i, j];
                    newRow++;
                }
            }

            return newMatrix;
        }

        //In ra ma trận sau khi xóa dòng thứ k
        static int[,] PrintDeleteRow(int[,] matrix, int k)
        {
            Console.WriteLine($"\n5. XOA DONG THU {k} TRONG MA TRAN");
            matrix = DeleteRow(matrix, k);
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            for (int i = 0; i < rows; i++) {
                for (int j = 0; j < cols; j++)
                    Console.Write(matrix[i, j] + " ");
                Console.WriteLine();
            }
            return matrix;
        }

        //Xóa cột có chỉ số chỉ định khỏi ma trận và trả về ma trận mới
        static int[,] DeleteColumn(int[,] matrix, int colToDelete)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            if (colToDelete == -1 || colToDelete >= cols)
                return matrix;

            int[,] newMatrix = new int[rows, cols - 1];

            for (int i = 0; i < rows; i++) {
                int newCol = 0;
                for (int j = 0; j < cols; j++) {
                    if (j != colToDelete) {
                        newMatrix[i, newCol] = matrix[i, j];
                        newCol++;
                    }
                }
            }

            return newMatrix;
        }

        //Tìm chỉ số cột chứa phần tử lớn nhất đầu tiên trong ma trận
        static int FindColWithMaxVal(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int max = FindMax(matrix);

            int colToDelete = -1;
            for (int i = 0; i < rows && colToDelete == -1; i++) {
                for (int j = 0; j < cols; j++) {
                    if (matrix[i, j] == max) {
                        colToDelete = j;
                        break;
                    }
                }
            }

            return colToDelete;
        }

        //In ra ma trận sau khi xóa cột chứa phần tử lớn nhất đầu tiên
        static int[,] PrintDeleteColWithMaxVal(int[,] matrix, int colToDelete)
        {
            Console.WriteLine("\n6. XOA COT CHUA PHAN TU LON NHAT TRONG MA TRAN");
            matrix = DeleteColumn(matrix, colToDelete);
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            for (int i = 0; i < rows; i++) {
                for (int j = 0; j < cols; j++)
                    Console.Write(matrix[i, j] + " ");
                Console.WriteLine();
            }
            return matrix;
        }

        //Tạo một ma trận ngẫu nhiên
        static int[,] CreateRandomMatrix(int n, int m, int min = 0, int max = 100)
        {
            Random rand = new Random();
            int[,] matrix = new int[n, m];

            for (int i = 0; i < n; i++) {
                for (int j = 0; j < m; j++)
                    matrix[i, j] = rand.Next(min, max + 1);
            }

            return matrix;
        }

        static void Main(string[] args)
        {
            Console.Write("Nhap so dong n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot m: ");
            int m = int.Parse(Console.ReadLine());

            int[,] matrix = CreateRandomMatrix(n, m, 0, 50);
            int[,] originalMatrix = (int[,])matrix.Clone();

            PrintMatrix(matrix);
            FindMaxMin(matrix);
            PrintRowWithMaxSum(matrix);
            PrintSumNonPrimeNums(matrix);

            Console.Write("\nNhap dong thu k can xoa: ");
            int k = int.Parse(Console.ReadLine());

            int colWithMax = FindColWithMaxVal(originalMatrix);

            if (k >= 0 && k < matrix.GetLength(0))
                matrix = PrintDeleteRow(matrix, k);
            else
                Console.WriteLine("\n5. Dong k khong hop le! Khong thuc hien xoa dong.");

            matrix = PrintDeleteColWithMaxVal(matrix, colWithMax);
        }
    }
}