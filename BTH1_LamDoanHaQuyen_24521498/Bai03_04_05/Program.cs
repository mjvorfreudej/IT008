using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai03_04_05
{
    class Program
    {
        //Kiểm tra ngày tháng năm có hợp lệ không
        static void CheckValidDate()
        {
            Console.WriteLine("1. Kiem tra ngay thang nam hop le.");
            Console.Write("Nhap ngay: ");
            int day = int.Parse(Console.ReadLine());
            Console.Write("Nhap thang: ");
            int month = int.Parse(Console.ReadLine());
            Console.Write("Nhap nam: ");
            int year = int.Parse(Console.ReadLine());

            if (IsValidDate(day, month, year))
                Console.WriteLine("Ngay hop le.");
            else
                Console.WriteLine("Ngay khong hop le.");
        }

        //Kiểm tra tính hợp lệ của ngày tháng năm
        static bool IsValidDate(int day, int month, int year)
        {
            if (year < 1 || month < 1 || month > 12 || day < 1)
                return false;
            int daysInMonth = GetDaysInMonth(month, year);
            return day <= daysInMonth;
        }

        //Hàm in ra số ngày của một tháng/năm được nhập vào
        static void PrintDaysInMonth()
        {
            Console.WriteLine("2. Cho biet so ngay trong thang.");
            Console.Write("Nhap thang: ");
            int month = int.Parse(Console.ReadLine());
            Console.Write("Nhap nam: ");
            int year = int.Parse(Console.ReadLine());

            int daysInMonth = GetDaysInMonth(month, year);
            if (daysInMonth > 0)
                Console.WriteLine($"Thang {month} cua nam {year} co {daysInMonth} ngay.");
            else
                Console.WriteLine("Thang hoac nam khong hop le.");
        }

        //Hàm trả về số ngày trong một tháng, xét cả năm nhuận cho tháng 2
        static int GetDaysInMonth(int month, int year)
        {
            if (month < 1 || month > 12 || year < 1)
                return 0;
            switch (month) {
                case 2:
                    return DateTime.IsLeapYear(year) ? 29 : 28;
                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;
                default:
                    return 31;
            }
        }

        //Hàm in ra thứ trong tuần ứng với ngày được nhập
        static void PrintDayOfWeek()
        {
            Console.WriteLine("3. Cho biet thu trong tuan cua mot ngay.");
            Console.Write("Nhap ngay: ");
            int day = int.Parse(Console.ReadLine());
            Console.Write("Nhap thang: ");
            int month = int.Parse(Console.ReadLine());
            Console.Write("Nhap nam: ");
            int year = int.Parse(Console.ReadLine());

            if (IsValidDate(day, month, year)) {
                DateTime dt = new DateTime(year, month, day);
                Console.WriteLine($"Ngay {day}/{month}/{year} la {GetDayOfWeek(dt.DayOfWeek)}.");
            } else {
                Console.WriteLine("Ngay khong hop le.");
            }
        }

        //Hàm chuyển kiểu DayOfWeek thành chuỗi tiếng Việt tương ứng
        static string GetDayOfWeek(DayOfWeek dayOfWeek)
        {
            switch (dayOfWeek) {
                case DayOfWeek.Monday: return "Thu hai";
                case DayOfWeek.Tuesday: return "Thu ba";
                case DayOfWeek.Wednesday: return "Thu tu";
                case DayOfWeek.Thursday: return "Thu nam";
                case DayOfWeek.Friday: return "Thu sau";
                case DayOfWeek.Saturday: return "Thu bay";
                case DayOfWeek.Sunday: return "Chu nhat";
                default: return "";
            }
        }

        static void Main(string[] args)
        {
            CheckValidDate();
            PrintDaysInMonth();
            PrintDayOfWeek();
        }
    }
}