namespace ACT19
{
    public class Driver
    {
        public delegate int IntOps(int firstValue, int secondValue);
        public static void Main()
        {
            const string PowSymbol = "**";
            const char EqualsSymbol = '=';
            const int minRange = 2;
            const int maxRange = 5;
            IntOps calcPow = Pow;
            Random rnd = new Random();
            int baseVal = rnd.Next(minRange,maxRange);
            int powVal = rnd.Next(minRange,maxRange);
            
            Console.WriteLine($"{baseVal}{PowSymbol}{powVal}{EqualsSymbol}{calcPow(baseVal, powVal)}");
        }
        public static int Pow(int x,int y)
        {
            return Convert.ToInt32(Math.Truncate(Math.Pow((double)x,(double)y)));
        }
    }
}