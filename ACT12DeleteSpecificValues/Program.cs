using System.Collections;

namespace ACT12
{
    public class Driver
    {
        public static void Main()
        {
            const int MinPossibleValue = 50;
            const int MaxPossibleValue = 150;
            const int AmountValues = 100;
            const int NotBiggerThan = 100;
            Random rnd = new Random();
            List<int> numList = new List<int>();

            for(int i = 0; i<AmountValues; i++)
            {
                numList.Add(rnd.Next(MinPossibleValue, MaxPossibleValue));
            }
            for(int i = 0;i<numList.Count; i++)
            {
                if (numList[i] > NotBiggerThan)
                {
                    numList.RemoveAt(i);
                    i--;
                }
            }
            for(int i = 0; i< numList.Count; i++)
            {
                Console.WriteLine(numList[i]);
            }
        }
    }
}