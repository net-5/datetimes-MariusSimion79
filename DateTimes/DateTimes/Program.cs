using System;
using System.Globalization;

namespace DateTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1
            DisplayDate();

            // 2
            // DisplayModifiedYears();

            //3
            // FormatDate();

            //4
            // IncreaseSeconds();

            //5
            // ShowMillisecons();

            //6
            // IncreaseMonths();

            //7
            // GetFirstAndLastSecond();

            //8
            // GetDifferenceInSeconds();

            //9
            // DisplayAge();

            //10
            // Display30Days();

            //11
            // DaysCounter();

            //12
            // YesterdayTodayTomorrow();

            //13
            // Print5Days();

            //14
            // FirstDayOfWeek();

            //15
            // GetDays();

            //16
            GetSundays();


        }

        #region 01 Format date according to instructions
        public static void DisplayDate()
        {
            // 1a) 
            Console.Write("1a) Current date and time: ");
            Console.WriteLine(DateTime.Now);
            //  1b)
            Console.Write("1b) Current year is: ");
            Console.WriteLine(DateTime.Now.Year);
            //  1c)
            Console.Write("1c) Current month is: ");
            Console.WriteLine((YearMonths)DateTime.Now.Month);
            //  1d)
            Console.Write("1d) Current week is: ");
            Console.WriteLine(WeekOfTheYear());
            //  1e)
            Console.Write("1e) Current weekday is: ");
            Console.WriteLine($"Today is {DateTime.Now.DayOfWeek}");
            //  1f)
            Console.Write("1f) The day of the year is: ");
            Console.WriteLine($"Today is day no. {DateTime.Now.DayOfYear} of year {DateTime.Now.Year}");
            //  1g)  
            Console.Write("1f) The day of the month is: ");
            Console.WriteLine($"Today is day no. {DateTime.Now.Day} of month {DateTime.Now.Month}");
            //  1h)  
            Console.Write("1h) The day of week is: ");
            Console.WriteLine($"Today is day no. {DayOfTheWeek()} of the {WeekOfTheYear()}");
            // 1j)
            Console.WriteLine(IsLeapYear());
            Console.WriteLine("*************************************************************************************");
        }
        #endregion

        #region 01d Write a program to display week number of the year
        public static string WeekOfTheYear()
        {
            return ($"Week { CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(DateTime.Now, CalendarWeekRule.FirstDay, DayOfWeek.Monday)}");

        }
        #endregion

        #region 01h Write a program to display day of week
        public static int DayOfTheWeek()
        {
            int dayNum = 0;
            switch (DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    dayNum = 1;
                    break;
                case DayOfWeek.Tuesday:
                    dayNum = 2;
                    break;
                case DayOfWeek.Wednesday:
                    dayNum = 3;
                    break;
                case DayOfWeek.Thursday:
                    dayNum = 4;
                    break;
                case DayOfWeek.Friday:
                    dayNum = 5;
                    break;
                case DayOfWeek.Saturday:
                    dayNum = 6;
                    break;
                case DayOfWeek.Sunday:
                    dayNum = 7;
                    break;
                default:
                    break;
            }


            return dayNum;
        }







        #endregion

        #region 01j Write a program to display day of year
        public static string IsLeapYear()
        {
            if (DateTime.IsLeapYear(DateTime.Now.Year))
            {
                return $"1j) The year {DateTime.Now.Year} is a leap year";
            }
            else
            {
                return $"1j) The year {DateTime.Now.Year} is not a leap year";
            }
        }
        #endregion

        #region 02 Add N years to the current date and display the new date
        public static void DisplayModifiedYears()
        {
            Console.Write("Please enter the years amount to increase: ");
            int yearsNo = int.Parse(Console.ReadLine());
            if (yearsNo == 1)
            {
                Console.WriteLine($"After {yearsNo} year, the date will be: {DateTime.Now.AddYears(yearsNo)}");
            }
            else
            {
                Console.WriteLine($"After {yearsNo} years, the date will be: {DateTime.Now.AddYears(yearsNo)}");
            }


        }



        #endregion

        #region 03 Display a date in user friendly strings
        public static void FormatDate()
        {
            var weekday = DateTime.Now.DayOfWeek;
            var day = DateTime.Now.Day;
            var monthNo = DateTime.Now.Month;
            var month = (YearMonths)DateTime.Now.Month;
            var year = DateTime.Now.Year;
            var hour = DateTime.Now.Hour;
            var minute = DateTime.Now.Minute;
            var second = DateTime.Now.Second;
            Console.WriteLine($"Today is {weekday}, {day}.{month}.{year}.\nIt`s {hour} o`clock, {minute} minutes and {second} seconds.");
        }
        #endregion

        #region 04 Add 5 seconds to current date and print the new date
        public static void IncreaseSeconds()
        {
            Console.WriteLine($"Now it`s {DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second}. " +
                $"In 5 seconds, the time will be: " +
                $"{DateTime.Now.AddSeconds(5).Hour}:{DateTime.Now.AddSeconds(5).Minute}:{DateTime.Now.AddSeconds(5).Second}");
        }
        #endregion

        #region 05 Display current time in milliseconds
        public static void ShowMillisecons()
        {
            DateTime time = DateTime.Now;
            Console.WriteLine($"{time.Millisecond + 1000 * time.Second + 60000 * DateTime.Now.Minute + 3600000 * time.Hour} milliseconds has passed from midnight till now, {time.Hour}:{time.Minute}:{time.Second}:{time.Millisecond}");
        }
        #endregion

        #region 06 Calculate the date 6 months from the current date
        public static void IncreaseMonths()
        {
            DateTime date = DateTime.Today;
            DateTime newDate = date.AddMonths(6);
            Console.WriteLine($"Current date is: {date.Day}.{date.Month}.{date.Year}. After 6 months, the date will be {newDate.Day}.{newDate.Month}.{newDate.Year}.");
        }
        #endregion

        #region 07 Get the first and last second of a day
        public static void GetFirstAndLastSecond()
        {
            DateTime time = DateTime.Today;
            Console.WriteLine($"Today`s first second: {time.AddSeconds(1).Hour}:{time.AddSeconds(1).Minute}:{time.AddSeconds(1).Second}");
            Console.WriteLine($"Today`s last second: {time.AddDays(1).AddSeconds(-1).Hour}:{time.AddDays(1).AddSeconds(-1).Minute}:{time.AddDays(1).AddSeconds(-1).Second}");
        }
        #endregion

        #region 08 Calculate the difference between 2 dates in seconds
        public static void GetDifferenceInSeconds()
        {
            DateTime firstDate = new DateTime(2018, 4, 24, 2, 15, 10);
            DateTime secondDate = new DateTime(2019, 4, 24, 2, 15, 10);

            var differenceInSeconds = (firstDate - secondDate).TotalSeconds;
            Console.WriteLine($"Between {firstDate} and {secondDate} is a difference of {differenceInSeconds} seconds");
        }
        #endregion

        #region 09 Calculate the age of a person based on given birthdate
        public static void DisplayAge()
        {
            Console.Write("Please enter a birthdate (dd,mm,yyyy): ");
            string date = Console.ReadLine();
            DateTime birthDate = DateTime.Parse(date);
            var age = DateTime.Now.Year - birthDate.Year - (birthDate.DayOfYear < DateTime.Now.DayOfYear ? 0 : 1);
            Console.WriteLine($"If your birthdate is {birthDate.Day}.{birthDate.Month}.{birthDate.Year}, you are {age} years old.");
        }
        #endregion

        #region 10 Remove and Add 30 days from current date and display them
        public static void Display30Days()
        {
            DateTime today = DateTime.Today;
            DateTime before30 = today.AddDays(-30);
            DateTime after30 = today.AddDays(30);
            Console.WriteLine($"Before 30 days = {before30.Day}.{before30.Month}.{before30.Year}");
            Console.WriteLine($"After 30 days = { after30.Day}.{ after30.Month}.{ after30.Year}");
        }
        #endregion

        #region 11 Calculate how many days are between 2 dates
        public static void DaysCounter()
        {

            Console.Write("Please enter first date (dd,mm,yyyy): ");
            string firstDate = Console.ReadLine();
            DateTime date1 = DateTime.Parse(firstDate);
            Console.Write("Please enter second date (dd,mm,yyyy): ");
            string secondDate = Console.ReadLine();
            DateTime date2 = DateTime.Parse(secondDate);

            TimeSpan elapsedTime = (date1 - date2);

            if (elapsedTime.Days > 0)
            {
                Console.WriteLine($"Between {date1.Day}.{date1.Month}.{date1.Year} and {date2.Day}.{date2.Month}.{date2.Year} are {elapsedTime.Days} days.");
            }
            else
            {
                Console.WriteLine($"Between {date1.Day}.{date1.Month}.{date1.Year} and {date2.Day}.{date2.Month}.{date2.Year} are {elapsedTime.Days * (-1)} days.");
            }
        }
        #endregion

        #region 12 Print Yesterday, Today and Tomorrow
        public static void YesterdayTodayTomorrow()
        {
            DateTime today = DateTime.Now;
            DateTime yesterday = today.AddDays(-1);
            DateTime tomorrow = today.AddDays(1);

            Console.WriteLine($"Yesterday :  {yesterday.ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-US"))}");
            Console.WriteLine($"Today :  {today.Year}-{today.Month}-{today.Day}");
            Console.WriteLine($"Tomorrow :  {tomorrow.Year}-{tomorrow.Month}-{tomorrow.Day}");
        }
        #endregion

        #region 13 Program to print next 5 days starting today
        public static void Print5Days()
        {
            DateTime today = DateTime.Now.Date;
            for (DateTime day = today; day <= today.AddDays(5); day = day.AddDays(1))
            {
                Console.WriteLine($"{ day.Day}-{day.Month}-{day.Year}");
            }
        }
        #endregion

        #region 14 Program to find the Monday of a given week and year
        public static void FirstDayOfWeek()
        {
            Console.Write("Please enter the year and the week (yyyy,ww): ");
            string date = Console.ReadLine();
            string[] dates = date.Split(",");


            DateTime buildedDate = new DateTime(int.Parse(dates[0]), 1, 1);
            DateTime newDate = buildedDate.AddDays(7 * (int.Parse(dates[1]) - 1));

            var day = newDate.DayOfWeek;
            DateTime result = newDate;
            switch (day)
            {
                case DayOfWeek.Monday:
                    result = newDate;
                    break;
                case DayOfWeek.Tuesday:
                    result = newDate.AddDays(-1);
                    break;
                case DayOfWeek.Wednesday:
                    result = newDate.AddDays(-2);
                    break;
                case DayOfWeek.Thursday:
                    result = newDate.AddDays(-3);
                    break;
                case DayOfWeek.Friday:
                    result = newDate.AddDays(-4);
                    break;
                case DayOfWeek.Saturday:
                    result = newDate.AddDays(-5);
                    break;
                case DayOfWeek.Sunday:
                    result = newDate.AddDays(-6);
                    break;
                default:
                    break;
            }
            Console.WriteLine($"{result.ToString("ddd MMM d", CultureInfo.CreateSpecificCulture("en-US"))} 00:00:00 {result.Year} ");
        }


        #endregion

        #region 15 Get days between 2 dates
        public static void GetDays()
        {
            Console.Write("Please enter first date (dd,mm,yyyy): ");
            string firstDate = Console.ReadLine();
            DateTime date1 = DateTime.Parse(firstDate);
            Console.Write("Please enter second date (dd,mm,yyyy): ");
            string secondDate = Console.ReadLine();
            DateTime date2 = DateTime.Parse(secondDate);
            TimeSpan elapsedTime = (date1 - date2);
            if (elapsedTime.TotalDays > 0)
            {
                Console.WriteLine($"{elapsedTime.TotalDays} days, 0:00:00");
            }
            else
            {
                Console.WriteLine($"{elapsedTime.TotalDays * (-1)} days, 0:00:00");
            }
        }
        #endregion

        #region 16 Select all Sunday`s across a specified year and display their dates
        public static void GetSundays()
        {
            Console.Write("Please enter the year: ");
            var year = int.Parse(Console.ReadLine());
            DateTime firstday = new DateTime(year, 1, 1);
            DateTime lastDay = new DateTime(year, 12, 31);
            DateTime firstSunday = firstday;

            switch (firstday.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    firstSunday = firstSunday.AddDays(6);
                    break;
                case DayOfWeek.Tuesday:
                    firstSunday = firstSunday.AddDays(5);
                    break;
                case DayOfWeek.Wednesday:
                    firstSunday = firstSunday.AddDays(4);
                    break;
                case DayOfWeek.Thursday:
                    firstSunday = firstSunday.AddDays(3);
                    break;
                case DayOfWeek.Friday:
                    firstSunday = firstSunday.AddDays(2);
                    break;
                case DayOfWeek.Saturday:
                    firstSunday = firstSunday.AddDays(1);
                    break;
                case DayOfWeek.Sunday:
                    break;
                default:
                    break;
            }
            while (firstSunday <= lastDay)
            {
                Console.WriteLine($"{firstSunday.ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-US"))}");
                firstSunday = firstSunday.AddDays(7);
            }
        }
        #endregion
    }

    public enum YearMonths
    {
        January, February, March, April, May, June, July, August, September, October, November, December
    }

}

