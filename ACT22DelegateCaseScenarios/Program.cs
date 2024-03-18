namespace ACT22
{
    public class Driver
    {
        public delegate string CaseScenario(int num);
        public static void Main()
        {
            const int CaseValue = 4;
            CaseScenario result = CaseScenarioResult;

            Console.WriteLine(result(CaseValue));
        }
        public static string CaseScenarioResult(int num)
        {
            if(num%2==0)
            {
                return (num * 2).ToString();
            }
            return $"El numero {num} es senar";
        }
    }
}