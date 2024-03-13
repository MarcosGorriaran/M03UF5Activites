namespace ACT20
{
    public class Driver
    {
        public delegate double DoubleOps(double baseVal);
        public static void Main()
        {
            const char SquareRoot = '';
            double baseVal;
            DoubleOps calc = Math.Sqrt;
            Random rnd = new Random();
            
            baseVal = rnd.NextDouble();

            Console.WriteLine();
        }
    }
}