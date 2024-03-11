using System.Collections;

namespace ACT10
{
    public class Driver
    {
        public static void Main()
        {
            string[] transformElements = new string[]
            {
                "Hello",
                "Something",
                "Yada yada yada",
                "More stuff"
            };
            ArrayList stringList = new ArrayList(transformElements);

            for(int i = 0; i < stringList.Count; i++)
            {
                Console.WriteLine(stringList[i]);
            }
        }
    }
}