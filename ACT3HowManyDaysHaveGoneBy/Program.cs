namespace ACT3
{
    public class Driver
    {
        public static void Main()
        {
            DateOnly dateOnly = DateOnly.Parse(Console.ReadLine()??"");
            Console.WriteLine(DaysBetweenDates(dateOnly,new DateOnly(DateTime.Now.Year,DateTime.Now.Month,DateTime.Now.Day)));


        }

        public static int DaysBetweenDates(DateOnly firstDate, DateOnly secondDate)
        {
            DateOnly trackerDate;
            int days=0;
            if(firstDate>secondDate)
            {
                trackerDate = new DateOnly(secondDate.Year,secondDate.Month, secondDate.Day);
                while (trackerDate != firstDate)
                {
                    days++;
                    trackerDate = trackerDate.AddDays(1);
                }
            }
            else
            {
                trackerDate = new DateOnly(firstDate.Year, firstDate.Month, firstDate.Day);
                while (trackerDate != secondDate)
                {
                    days++;
                    trackerDate = trackerDate.AddDays(1);
                }
            }
            return days;
        }
    }
}