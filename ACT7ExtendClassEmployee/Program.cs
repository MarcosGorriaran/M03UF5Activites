

using System.Runtime.CompilerServices;


namespace ACT7
{
    public class Driver
    {
        public static void Main()
        {
            const string DefDate = "01/01/1970";
            const int AmountEmployees = 5;
            const int AmountSales = 5;
            const int AmountRandomYears = 20;
            Random rnd = new Random();
            DateOnly defDate = DateOnly.Parse(DefDate);
            List<Employee> employeeList = new List<Employee>();

            for(int i = 0; i < AmountEmployees; i++)
            {
                employeeList.Add(new Employee(defDate.AddYears(rnd.Next(AmountRandomYears))));
            }
            for(int i = 0;i < AmountSales; i++)
            {
                employeeList.Add(new SalesEmployee(defDate.AddYears(rnd.Next(AmountRandomYears))));
            }
            employeeList.Sort();
            for(int i = 0;i<employeeList.Count ; i++) 
            {
                Console.WriteLine(employeeList[i]);
            }
        }
    }
}
