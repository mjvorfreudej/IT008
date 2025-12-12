using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai04
{
    public class PhanSo : IComparable<PhanSo>
    {
        public long TuSo { get; protected set; }
        public long MauSo { get; protected set; }

        public PhanSo(long tuSo, long mauSo)
        {
            if (mauSo == 0)
                throw new DivideByZeroException("Mẫu số không được bằng 0!");

            TuSo = tuSo;
            MauSo = mauSo;
            ChuanHoa();
            RutGon();
        }

        protected void ChuanHoa()
        {
            if (MauSo < 0)
            {
                TuSo = -TuSo;
                MauSo = -MauSo;
            }
        }

        protected static long UCLN(long a, long b)
        {
            while (b != 0)
            {
                long t = a % b;
                a = b;
                b = t;
            }
            return Math.Max(a, 1);
        }

        protected void RutGon()
        {
            long ucln = UCLN(Math.Abs(TuSo), MauSo);
            if (ucln > 1)
            {
                TuSo /= ucln;
                MauSo /= ucln;
            }
        }

        // Toán tử cộng
        public static PhanSo operator +(PhanSo a, PhanSo b)
            => new PhanSo(a.TuSo * b.MauSo + b.TuSo * a.MauSo,
                          a.MauSo * b.MauSo);

        // Toán tử trừ
        public static PhanSo operator -(PhanSo a, PhanSo b)
            => new PhanSo(a.TuSo * b.MauSo - b.TuSo * a.MauSo,
                          a.MauSo * b.MauSo);

        // Toán tử nhân
        public static PhanSo operator *(PhanSo a, PhanSo b)
            => new PhanSo(a.TuSo * b.TuSo,
                          a.MauSo * b.MauSo);

        // Toán tử chia
        public static PhanSo operator /(PhanSo a, PhanSo b)
        {
            if (b.TuSo == 0)
                throw new DivideByZeroException("Không thể chia cho phân số có tử bằng 0!");
            return new PhanSo(a.TuSo * b.MauSo,
                              a.MauSo * b.TuSo);
        }

        // So sánh hai phân số để sắp xếp hoặc tìm lớn nhất
        public int CompareTo(PhanSo other)
        {
            if (other == null) return 1;
            long trai = TuSo * other.MauSo;
            long phai = other.TuSo * MauSo;
            return trai.CompareTo(phai);
        }

        public override string ToString() => $"{TuSo}/{MauSo}";
    }

    class Program
    {
        static long ReadLong(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                if (long.TryParse(Console.ReadLine(), out long v))
                    return v;
                Console.WriteLine("Lỗi: Vui lòng nhập số nguyên hợp lệ!");
            }
        }

        static PhanSo NhapPhanSo(string tenHienThi)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine($"\nNhập {tenHienThi}");
                    long tu = ReadLong($"Nhập tử số {tenHienThi}: ");
                    long mau = ReadLong($"Nhập mẫu số {tenHienThi}: ");
                    return new PhanSo(tu, mau);
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine($"{ex.Message} Vui lòng nhập lại!");
                }
            }
        }

        static int ReadPositiveInt(string prompt)
        {
            while (true)
            {
                long v = ReadLong(prompt);
                if (v >= 1 && v <= int.MaxValue) return (int)v;
                Console.WriteLine("Lỗi: Số lượng phải là số nguyên dương!");
            }
        }

        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=== CHƯƠNG TRÌNH TÍNH TOÁN PHÂN SỐ ===");

            PhanSo p1 = NhapPhanSo("phân số (p1)");
            PhanSo p2 = NhapPhanSo("phân số (p2)");

            Console.WriteLine($"\nPhân số 1: {p1}");
            Console.WriteLine($"Phân số 2: {p2}");

            Console.WriteLine($"\nTổng = {p1 + p2}");
            Console.WriteLine($"Hiệu = {p1 - p2}");
            Console.WriteLine($"Tích = {p1 * p2}");
            try
            {
                Console.WriteLine($"Thương = {p1 / p2}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Lỗi phép chia: {ex.Message}");
            }

            int n = ReadPositiveInt("\nNhập số lượng phân số: ");
            PhanSo[] ds = new PhanSo[n];
            for (int i = 0; i < n; i++)
                ds[i] = NhapPhanSo($"phân số (p{i + 1})");

            // Tìm phân số lớn nhất
            PhanSo max = ds[0];
            for (int i = 1; i < n; i++)
                if (ds[i].CompareTo(max) > 0) max = ds[i];
            Console.WriteLine($"\nPhân số lớn nhất: {max}");

            // Sắp xếp tăng dần
            Array.Sort(ds);
            Console.WriteLine("\nDanh sách phân số tăng dần:");
            foreach (PhanSo p in ds) Console.WriteLine(p);
        }
    }
}