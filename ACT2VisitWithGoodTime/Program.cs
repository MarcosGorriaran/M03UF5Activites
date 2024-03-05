// See https://aka.ms/new-console-template for more information
using VisitPlaner;

namespace ACT2
{
    public class Driver
    {
        public static void Main() 
        {
            const string AskDate = "Proporcioname la fecha: ";
            const string AskName = "Proporcioname el nombre del dueño: ";
            const string AskDni = "Proporcioname el DNI del dueño: ";
            const string AskReason = "Detallame la razon de la visita: ";
            const string WrongDateFormat = "El formato proporcionado es incorrecto";
            const char startTextArea = '{';
            const char endTextArea = '}';
            const int setVisits = 1;
            Visit[] visits = new Visit[setVisits];
            bool error;
            for (int i = 0; i < setVisits; i++)
            {
                string dni = "";
                string ownerName = "";
                string reasonVisit = ""+startTextArea;
                DateTime date = new DateTime();

                Console.Write(AskDni);
                dni = Console.ReadLine() ?? "";

                Console.Write(AskName);
                ownerName = Console.ReadLine() ?? "";


                do
                {
                    error = false;
                    try
                    {
                        Console.Write(AskDate);
                        date = DateTime.Parse(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        error = true;
                        Console.WriteLine(WrongDateFormat);
                    }

                } while (error);
                Console.WriteLine(AskReason);
                Console.Write(startTextArea);
                do
                {
                    reasonVisit += Console.ReadLine()??"";
                    reasonVisit += Environment.NewLine;
                } while (!reasonVisit.EndsWith(endTextArea+Environment.NewLine));
                visits[i] = new Visit(new Owner(dni, ownerName),date,reasonVisit);

            }
            for (int i = 0; i < visits.Length; i++)
            {
                Console.WriteLine(visits[i]);
            }

        }
    }
}