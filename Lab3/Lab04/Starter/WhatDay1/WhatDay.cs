using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Text;


namespace WhatDay1
{
    enum MonthName
    {
        January,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }
    class WhatDay
    {
        static void Main(string[] args)
        {
            try
            {
            Console.Write("Please enter the year: ");
            int yearNum = int.Parse(Console.ReadLine());
            bool isLeapYear = (yearNum % 4 == 0)
                && (yearNum % 100 !=0
                    || yearNum % 400 == 0);
            int maxDayNum =isLeapYear ? 366 : 365;
            //if (isLeapYear )
            //    {
            //        Console.WriteLine(" IS a leap year");
            //    } else
            //    {
            //        Console.WriteLine("is NOT a leap year");
            //    }
            System.Console.Write("Enter day number between 1 and {0}:",maxDayNum);
            int dayNum = int.Parse(System.Console.ReadLine());
            if (dayNum < 1 || dayNum > maxDayNum)
                {
                    throw new ArgumentOutOfRangeException("Day out of range");
                }
            int monthNum = 0;
                if (isLeapYear)
                {
                    foreach (int daysInMonth in DaysInLeapMonths)
                    {
                        if (dayNum <= daysInMonth)
                        {
                            break;
                        }
                        else
                        {
                            dayNum -= daysInMonth;
                            monthNum++;
                        }
                    }
                } else
                {
                    foreach (int daysInMonth in DaysInMonths)
                    {
                        if (dayNum <= daysInMonth)
                        {
                            break;
                        }
                        else
                        {
                            dayNum -= daysInMonth;
                            monthNum++;
                        }
                    }
            }
            MonthName temp = (MonthName)monthNum;
            string monthName = temp.ToString();
            Console.WriteLine("{0} {1}", dayNum, monthName);

            } catch (Exception caught) {
                Console.WriteLine(caught);
            }


            //if (dayNum <= 31) { // January
            //    goto End;
            //} else {
            //    dayNum -= 31;
            //    monthNum++;
            //}

            //if (dayNum <= 28) { // February
            //    goto End;
            //} else {
            //    dayNum -= 28;
            //    monthNum++;
            //}

            //if (dayNum <= 31) { // March
            //    goto End;
            //} else {
            //    dayNum -= 31;
            //    monthNum++;
            //}

            //if (dayNum <= 30) { // April
            //    goto End;
            //} else {
            //    dayNum -= 30;
            //    monthNum++;
            //}

            //if (dayNum <= 31) { // May
            //    goto End;
            //} else {
            //    dayNum -= 31;
            //    monthNum++;
            //}


            //if (dayNum <= 30) { // June
            //    goto End;
            //} else {
            //    dayNum -= 30;
            //    monthNum++;
            //}

            //if (dayNum <= 31) { // July
            //    goto End;
            //} else {
            //    dayNum -= 31;
            //    monthNum++;
            //}

            //if (dayNum <= 31) { // August
            //    goto End;
            //} else {
            //    dayNum -= 31;
            //    monthNum++;
            //}

            //if (dayNum <= 30) { // September
            //    goto End;
            //} else {
            //    dayNum -= 30;
            //    monthNum++;
            //}

            //if (dayNum <= 31) { // October
            //    goto End;
            //} else {
            //    dayNum -= 31;
            //    monthNum++;
            //}
            //if (dayNum <= 30) { // November
            //    goto End;
            //} else {
            //    dayNum -= 30;
            //    monthNum++;
            //}
            //if (dayNum <= 31) { // December
            //    goto End;
            //} else {
            //    dayNum -= 31;
            //    monthNum++;
            //}
            //End:
            //    string monthName;

            //switch (monthNum)
            //{
            //    case 0:
            //        monthName = "January"; break;
            //    case 1:
            //        monthName = "February"; break;
            //    case 2:
            //        monthName = "March"; break;
            //    case 3:
            //        monthName = "April"; break;
            //    case 4:
            //        monthName = "May"; break;
            //    case 5:
            //        monthName = "June"; break;
            //    case 6:
            //        monthName = "July"; break;
            //    case 7:
            //        monthName = "August"; break;
            //    case 8:
            //        monthName = "September"; break;
            //    case 9:
            //        monthName = "October"; break;
            //    case 10:
            //        monthName = "November"; break;
            //    case 11:
            //        monthName = "December"; break;
            //    default:
            //        monthName = "not done yet"; break;
            //}
            //Console.WriteLine("{0} {1}", dayNum, monthName);

            //       and December											//
            //       Add a default label									//
            //////////////////////////////////////////////////////////////////

            //        }

            }
        // Don't modify anything below here
        static System.Collections.ICollection DaysInMonths
            = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        static System.Collections.ICollection DaysInLeapMonths
            = new int[12] { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

    }
}
