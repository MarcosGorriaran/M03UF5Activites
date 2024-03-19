namespace ACT24;

public class Driver
{
    public delegate bool IsNatural(int value);

    public static void Main()
    {
        const int TestCaseValue = 6;
        IsNatural check = value => value%2 == 0;

        Console.WriteLine($"{TestCaseValue}="+check(TestCaseValue));
    }
}