namespace ACT6
{
    public class Driver
    {
        public static void Main()
        {
            Employee employee = new Employee();
            employee.SetAgeTroughBirthDate(Console.ReadLine()??"");
            Console.WriteLine(employee.Age);
        }
    }
}