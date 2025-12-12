using System;
using System.Collections.Generic;
using System.Globalization;

namespace Bai05
{
    public abstract class BatDongSan
    {
        public string DiaDiem { get; protected set; }
        public decimal GiaBan { get; protected set; }
        public double DienTich { get; protected set; }

        protected BatDongSan(string diaDiem, decimal giaBan, double dienTich)
        {
            DiaDiem = diaDiem ?? "";
            GiaBan = giaBan;
            DienTich = dienTich;
        }

        public abstract string Loai { get; }

        public virtual string ThongTin()
        {
            return $"{Loai,-8} | Địa điểm: {DiaDiem} | Giá: {GiaBan:N0} VND | Diện tích: {DienTich} m²";
        }
    }

    public class KhuDat : BatDongSan
    {
        public KhuDat(string diaDiem, decimal giaBan, double dienTich) : base(diaDiem, giaBan, dienTich) { }

        public override string Loai => "KhuĐất";
    }

    public class NhaPho : BatDongSan
    {
        public int NamXayDung { get; private set; }
        public int SoTang { get; private set; }

        public NhaPho(string diaDiem, decimal giaBan, double dienTich, int namXayDung, int soTang)
            : base(diaDiem, giaBan, dienTich)
        {
            NamXayDung = namXayDung;
            SoTang = soTang;
        }

        public override string Loai => "NhàPhố";

        public override string ThongTin()
        {
            return base.ThongTin() + $" | Năm XD: {NamXayDung} | Số tầng: {SoTang}";
        }
    }

    public class ChungCu : BatDongSan
    {
        public int Tang { get; private set; }

        public ChungCu(string diaDiem, decimal giaBan, double dienTich, int tang)
            : base(diaDiem, giaBan, dienTich)
        {
            Tang = tang;
        }

        public override string Loai => "ChungCư";

        public override string ThongTin()
        {
            return base.ThongTin() + $" | Tầng: {Tang}";
        }
    }

    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            var ds = new List<BatDongSan>();

            Console.WriteLine("=== QUẢN LÝ BẤT ĐỘNG SẢN ĐẠI PHÚ ===\n");

            // 1) Nhập danh sách (theo từng loại)
            Console.Write("Nhập số lượng Khu Đất: ");
            int k = int.Parse(Console.ReadLine());
            for (int i = 0; i < k; i++)
            {
                Console.WriteLine($"\n-- Khu Đất #{i + 1} --");
                var item = NhapKhuDat();
                ds.Add(item);
            }

            Console.Write("\nNhập số lượng Nhà Phố: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\n-- Nhà Phố #{i + 1} --");
                var item = NhapNhaPho();
                ds.Add(item);
            }

            Console.Write("\nNhập số lượng Chung Cư: ");
            int c = int.Parse(Console.ReadLine());
            for (int i = 0; i < c; i++)
            {
                Console.WriteLine($"\n-- Chung Cư #{i + 1} --");
                var item = NhapChungCu();
                ds.Add(item);
            }

            // 2) Xuất danh sách
            Console.WriteLine("\n=== DANH SÁCH TÀI SẢN ===");
            foreach (var bds in ds)
                Console.WriteLine(bds.ThongTin());

            // 3) Tổng giá bán theo loại
            decimal tongKhuDat = 0, tongNhaPho = 0, tongChungCu = 0;
            foreach (var bds in ds)
            {
                if (bds is KhuDat) tongKhuDat += bds.GiaBan;
                else if (bds is NhaPho) tongNhaPho += bds.GiaBan;
                else if (bds is ChungCu) tongChungCu += bds.GiaBan;
            }

            Console.WriteLine("\n=== TỔNG GIÁ BÁN THEO LOẠI ===");
            Console.WriteLine($"Khu Đất : {tongKhuDat:N0} VND");
            Console.WriteLine($"Nhà Phố : {tongNhaPho:N0} VND");
            Console.WriteLine($"Chung Cư: {tongChungCu:N0} VND");
            Console.WriteLine($"TỔNG CỘNG: {(tongKhuDat + tongNhaPho + tongChungCu):N0} VND");

            // 4) Lọc theo điều kiện đề bài
            Console.WriteLine("\n=== LỌC THEO ĐIỀU KIỆN (đề bài) ===");
            bool foundAny = false;
            foreach (var bds in ds)
            {
                if (bds is KhuDat kd && kd.DienTich > 100.0)
                {
                    Console.WriteLine(kd.ThongTin());
                    foundAny = true;
                }
                else if (bds is NhaPho np && np.DienTich > 60.0 && np.NamXayDung >= 2019)
                {
                    Console.WriteLine(np.ThongTin());
                    foundAny = true;
                }
            }
            if (!foundAny) Console.WriteLine("(Không có mục nào thỏa điều kiện.)");

            // 5) Tìm kiếm Nhà Phố/Chung Cư
            Console.WriteLine("\n=== TÌM KIẾM NHÀ PHỐ / CHUNG CƯ ===");
            Console.Write("Nhập chuỗi địa điểm (không phân biệt hoa thường): ");
            string keyword = Console.ReadLine() ?? "";
            Console.Write("Nhập giá tối đa (VND): ");
            decimal giaMax = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Nhập diện tích tối thiểu (m2): ");
            double dtMin = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("\nKết quả tìm kiếm (Nhà Phố/Chung Cư):");
            bool found = false;
            foreach (var bds in ds)
            {
                if (bds is NhaPho || bds is ChungCu)
                {
                    bool matchDiaDiem = bds.DiaDiem.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0;
                    bool matchGia = bds.GiaBan <= giaMax;
                    bool matchDt = bds.DienTich >= dtMin;

                    if (matchDiaDiem && matchGia && matchDt)
                    {
                        Console.WriteLine(bds.ThongTin());
                        found = true;
                    }
                }
            }
            if (!found) Console.WriteLine("(Không có kết quả phù hợp.)");
        }

        static KhuDat NhapKhuDat()
        {
            Console.Write("Địa điểm: ");
            string diaDiem = Console.ReadLine() ?? "";
            Console.Write("Giá bán (VND): ");
            decimal gia = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Diện tích (m2): ");
            double dt = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            return new KhuDat(diaDiem, gia, dt);
        }

        static NhaPho NhapNhaPho()
        {
            Console.Write("Địa điểm: ");
            string diaDiem = Console.ReadLine() ?? "";
            Console.Write("Giá bán (VND): ");
            decimal gia = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Diện tích (m2): ");
            double dt = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Năm xây dựng: ");
            int nam = int.Parse(Console.ReadLine());
            Console.Write("Số tầng: ");
            int tang = int.Parse(Console.ReadLine());
            return new NhaPho(diaDiem, gia, dt, nam, tang);
        }

        static ChungCu NhapChungCu()
        {
            Console.Write("Địa điểm: ");
            string diaDiem = Console.ReadLine() ?? "";
            Console.Write("Giá bán (VND): ");
            decimal gia = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Diện tích (m2): ");
            double dt = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Tầng: ");
            int tang = int.Parse(Console.ReadLine());
            return new ChungCu(diaDiem, gia, dt, tang);
        }
    }
}