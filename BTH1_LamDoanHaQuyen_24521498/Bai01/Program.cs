using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Bai01
{
    class Program
    {
        //(a) Tổng số lẻ
        static int sumOfOddNums(int[] a)
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++) {
                if (a[i] % 2 != 0)
                    sum += a[i];   
            }
            return sum;
        }

        //Kiểm tra số nguyên tố
        static bool isPrime(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
                if (n % i == 0) return false;
            return true;
        }

        //(b) Đếm số nguyên tố
        static int countPrimes(int[] a)
        {
            int count = 0;
            for (int i = 0; i < a.Length; i++) {
                if (isPrime(a[i]))
                    count++;
            }
            return count;
        }

        //Kiểm tra số chính phương
        static bool isPerfectSquare(int n)
        {
            if (n < 0) return false;
            int sqrt = (int)Math.Sqrt(n);
            return sqrt * sqrt == n;
        }

        //(c) Tìm số chính phương nhỏ nhất
        static int findMinPerfectSquare(int[] a)
        {
            int min = int.MaxValue;
            bool has = false;

            for (int i = 0; i < a.Length; i++) {
                if (isPerfectSquare(a[i])) {
                    has = true;
                    if (a[i] < min)
                        min = a[i];
                }
            }

            return has ? min : -1;
        }

        //Tạo mảng ngẫu nhiên
        static int[] createRandomArray(int n)
        {
            Random rd = new Random();
            int[] a = new int[n];
            for (int i = 0; i < n; i++) {
                a[i] = rd.Next(0, 101);
            }
            return a;
        }

        static void Main(string[] args)
        {
            Console.Write("Nhap so phan tu n: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = createRandomArray(n);

            Console.WriteLine("Mang vua tao: ");
            for (int i = 0; i < a.Length; i++)
                Console.Write(a[i] + " ");
            Console.WriteLine();

            Console.WriteLine("Tong cac so le trong mang: " + sumOfOddNums(a));
            Console.WriteLine("So luong so nguyen to trong mang: " + countPrimes(a));
            Console.WriteLine("So chinh phuong nho nhat: " + findMinPerfectSquare(a));
        }
    }
}
