namespace ACT21
{
    public class Driver
    {
        public delegate int AvgCalc(int[] values);
        public static void Main()
        {
            const int AmountVal = 5;
            const int MinVal = 5;
            const int MaxVal = 20;

            int[] values = new int[AmountVal];
            AvgCalc calc = Avg;
            for(int i = 0; i < values.Length; i++)
            {
                Random rnd = new Random();
                values[i] = rnd.Next(MinVal, MaxVal);
            }
            Console.WriteLine(calc(values));
        }
        public static int Avg(int[] values)
        {
            int sum = 0;
            for(int i = 0; i < values.Length; ++i)
            {
                sum+= values[i];
            }
            return sum/values.Length;
        }
    }
}