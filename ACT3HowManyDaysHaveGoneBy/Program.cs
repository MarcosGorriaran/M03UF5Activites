namespace ACT3
{
    public class Driver
    {
        public static void Main()
        {
            DateTime dateOnly = DateTime.Parse(Console.ReadLine()??"");
            TimeSpan result = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day).Subtract(dateOnly);


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