using System;

namespace hello_console
{
    struct DateRange
    {
        public DateTime Start;
        public DateTime End;
 
        public DateRange(DateTime start, DateTime end)
        {
            this.Start = start;
            this.End = end;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DateTime start = new DateTime(2020, 8, 3);
            DateTime end = new DateTime(2020, 8, 16);
            DateRange range = new DateRange(start, end);
            DateTime[] holidays = {new DateTime(2020, 8, 8), new DateTime(2020, 8, 9),new DateTime(2020, 8, 15), new DateTime(2020, 8, 16)};

            int day = CountWorkingDays(start, end, holidays);

            Console.WriteLine("Regular date counter: " + day);

            int dayRange = CountWorkingDays(range, holidays);

            Console.WriteLine("Range date counter: " + day);
        }

        public static int CountWorkingDays(DateTime start, DateTime end, DateTime[] holidays) 
        {
            int days = 0;

            for (DateTime current = start; current <= end; current = current.AddDays(1))
            {
                if (!Array.Exists(holidays, element => element.Equals(current))) {
                    days++;
                }
            }

            return days;
        }

        public static int CountWorkingDays(DateRange range, DateTime[] holidays)
        {
            return CountWorkingDays(range.Start, range.End, holidays);
        }
    }
}
