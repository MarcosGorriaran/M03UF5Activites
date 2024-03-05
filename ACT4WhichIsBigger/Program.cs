namespace CompareDates
{
    public class Driver
    {
        public static void Main()
        {
            const string AskFirstDate = "Proporcioname la primera fecha (dd/mm/yyyy): ";
            const string AskSecondDate = "Proporcioname la segunda fecha (dd/mm/yyyy): ";
            const string SecondIsBigger = "Las segunda fecha es mas grande que la primera";
            const string SecondIsNotBigger = "La segunda fecha no es mas grande que la primera";
            const string ErrorWrongDateFormat = "El formato de fecha proporcionado es incorrecta";

            DateOnly firstDate = new DateOnly();
            DateOnly secondDate = new DateOnly();
            bool error;

            do
            {
                error = false;
                try
                {
                    Console.Write(AskFirstDate);
                    firstDate = DateOnly.Parse(Console.ReadLine() ?? "");
                }catch(FormatException)
                {
                    Console.WriteLine(ErrorWrongDateFormat);
                    error=true;
                }
            } while (error);

            do
            {
                error = false;
                try
                {
                    Console.Write(AskSecondDate);
                    secondDate = DateOnly.Parse(Console.ReadLine() ?? "");
                }
                catch (FormatException)
                {
                    Console.WriteLine(ErrorWrongDateFormat);
                    error = true;
                }
            } while (error);

            
            Console.WriteLine(secondDate>firstDate ? SecondIsBigger : SecondIsNotBigger);
        }
    }
}