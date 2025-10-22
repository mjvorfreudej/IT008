using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02
{
    class Program
    {
        const int MAX = 10000000;
        static long[] primeSum = new long[MAX + 1];

        //Sàng Eratosthenes để đánh dấu các số nguyên tố
        static void Precompute()
        {
            bool[] isPrime = new bool[MAX + 1];
            for (int i = 2; i <= MAX; i++)
                isPrime[i] = true;

            for (int i = 2; i * i <= MAX; i++) {
                if (isPrime[i]) {
                    for (int j = i * i; j <= MAX; j += i)
                        isPrime[j] = false;
                }
            }

            long sum = 0;
            for (int i = 2; i <= MAX; i++) {
                if (isPrime[i])
                    sum += i;
                primeSum[i] = sum;
            }
        }

        static void Main(string[] args)
        {
            Precompute();
            Console.Write("Nhap so nguyen duong n: ");
            int n = int.Parse(Console.ReadLine());
            if (n > MAX) n = MAX;
            Console.WriteLine($"Tong cac so nguyen to nho hon {n} la: {primeSum[n]}");
        }
    }
}