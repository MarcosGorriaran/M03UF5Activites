using System.Collections;

namespace ACT8
{
    public class Driver
    {
        public static void Main() 
        {
            const int AmountValues = 20;
            Random rnd = new Random();
            ArrayList numList = new ArrayList();
            int sum=0;
            for(int i = 0; i < AmountValues; i++)
            {
                numList.Add(rnd.Next());
            }
            for(int i = 0;i < numList.Count; i++)
            {
                sum += Convert.ToInt32(numList[i]);
            }
            Console.WriteLine(sum);
        }
    }
}