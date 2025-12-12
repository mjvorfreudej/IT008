using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Bai01
{
    class Program
    {
        static bool IsValidDate(int day, int month, int year)
        {
            if (year < 1 || month < 1 || month > 12 || day < 1)
                return false;
            int dayInMonths = GetDaysInMonth(month, year);
            return day <= dayInMonths;
        }

        static int GetDaysInMonth(int month, int year)
        {
            if (month < 1 || month > 12 || year < 1)
                return 0;
            switch (month)
            {
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

        static int GetFirstDayOfMonth(int month, int year)
        {
            return (int)new DateTime(year, month, 1).DayOfWeek;
        }

        static void PrintCalendar(int month, int year)
        {
            Console.WriteLine($"\nMonth: {month:D2}/{year}");
            Console.WriteLine();
            
            Console.WriteLine("+-----+-----+-----+-----+-----+-----+-----+");
            Console.WriteLine("| Sun | Mon | Tue | Wed | Thu | Fri | Sat |");
            Console.WriteLine("+-----+-----+-----+-----+-----+-----+-----+");
            
            int firstDay = GetFirstDayOfMonth(month, year);
            int daysInMonth = GetDaysInMonth(month, year);
            
            int currentDay = 1;
            
            for (int week = 0; week < 6; week++)
            {
                Console.Write("|");
                
                for (int dayOfWeek = 0; dayOfWeek < 7; dayOfWeek++)
                {
                    if ((week == 0 && dayOfWeek < firstDay) || currentDay > daysInMonth)
                    {
                        Console.Write("     |");
                    }
                    else
                    {
                        Console.Write($" {currentDay,3} |");
                        currentDay++;
                    }
                }
                
                Console.WriteLine();
                Console.WriteLine("+-----+-----+-----+-----+-----+-----+-----+");
                
                if (currentDay > daysInMonth)
                    break;
            }
        }

        static void Main(string[] args)
        {            
            Console.WriteLine("CHUONG TRINH IN LICH THANG");
            Console.WriteLine("===========================");
            
            int month, year;
            
            do
            {
                Console.Write("\nNhap thang (1-12): ");
                if (!int.TryParse(Console.ReadLine(), out month) || month < 1 || month > 12)
                {
                    Console.WriteLine("Thang khong hop le! Vui long nhap lai.");
                    continue;
                }
                break;
            } while (true);
            
            do
            {
                Console.Write("Nhap nam (>0): ");
                if (!int.TryParse(Console.ReadLine(), out year) || year < 1)
                {
                    Console.WriteLine("Nam khong hop le! Vui long nhap lai.");
                    continue;
                }
                break;
            } while (true);
            
            PrintCalendar(month, year);
        }
    }
}
