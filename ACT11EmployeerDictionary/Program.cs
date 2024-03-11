using System.Collections;

namespace ACT11
{
    public class Driver
    {
        public static void Main()
        {
            const int AmountEmployee=4;
            const string AskEmployeeName = "Proporciona el nombre del empleado: ";
            const string AskEmployeeSalary = "Proporciona el salario del trabajador: ";
            Hashtable employees = new Hashtable();

            for(int i = 0; i < AmountEmployee; i++)
            {
                Console.Write(AskEmployeeName);
                string name = Console.ReadLine();
                Console.Write(AskEmployeeSalary);
                int salary = int.Parse(Console.ReadLine());
                employees.Add(name, salary);
            }
            foreach(DictionaryEntry employee in employees)
            {
                Console.WriteLine(employee.Key+" "+employee.Value);
            }
        }
    }
}