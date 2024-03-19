using ACT25IdentifierMethods;
namespace ACT25;

public class Driver
{
    public static void Main()
    {
        Console.WriteLine(Identifier.Clean("MyΟβιεγτFinder"));
        Console.WriteLine(Convert.ToInt32("Ο"[0]));
    }
}