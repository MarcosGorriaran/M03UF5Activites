using System.Linq;
namespace ACT26;

public class Driver
{
    public static void Main()
    {
        const int AmountCases = 10;
        int[] values = new int[AmountCases];
        Random random = new Random();
        for(int i = 0; i< AmountCases; i++)
        {
            values[i] = random.Next();
        }

        IEnumerable<int> list = from value in values
                         where value%2 == 0
                         select value;
        foreach(int value in list)
        {
            Console.WriteLine(value);
        }
    }
}