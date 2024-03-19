using System.Collections;

namespace ACT9
{
    public class Driver
    {
        public static void Main()
        {
            const int AmountList = 20;
            const int Div = 2;
            List<int> numList = new List<int>();
            Random rnd = new Random();

            for (int i = 0; i < AmountList; i++)
            {
                numList.Add(rnd.Next());
            }
            for(int i = 0;i < numList.Count; i++)
            {
                if (numList[i] % Div == 0)
                {
                    Console.WriteLine(numList[i]);
                }
            }
            
        }
    }
}