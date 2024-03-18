namespace ACT23;

public class Driver
{
    public delegate int IntOps(int value);
    public static void Main()
    {
        const int TestVal = 20;
        IntOps fibonacci = FibonacciFind;
        Console.WriteLine(FibonacciFind(TestVal));
    }
    public static int FibonacciFind(int num)
    {
        List<int> fibonacci = new List<int>();
        for(int i = 0; i < num; i++)
        {
            int actual;
            int previous;
            if (i == 1)
            {
                fibonacci.Add(1);
            }
            if(i == 0)
            {
                actual = 0;
            }
            else
            {
                actual = fibonacci[i];
            }
            if(i-1 < 0)
            {
                previous = 0;
            }
            else
            {
                previous = fibonacci[i-1];
            }
            fibonacci.Add(actual+previous);
        }
        return fibonacci[fibonacci.Count-1];
    }
}