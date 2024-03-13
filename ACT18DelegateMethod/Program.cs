using System.Collections;

namespace ACT18
{
    
    public class Driver
    {
        public delegate void OrderElement(ref List<string> element);
        public static void Main()
        {
            const char RepeatedElement = 'l';
            const int MinLength = 10;
            const int MaxLength = 20;
            const int AmountValues = 5;
            List<string> arrayList = new List<string>();
            Random rnd = new Random();
            OrderElement ord = OrderList;
            for(int i = 0; i < AmountValues; i++)
            {
                arrayList.Add(new string(RepeatedElement, rnd.Next(MinLength, MaxLength)));
            }
            ord(ref arrayList);
            for(int i = 0;i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }
        }
        public static void OrderList(ref List<string> elemnt)
        {
            for(int i = 0; i < elemnt.Count - 1; i++)
            {
                for(int j = i; j< elemnt.Count; j++)
                {
                    if (elemnt[j].Length > elemnt[i].Length)
                    {
                        string aux = elemnt[j];
                        elemnt[j] = elemnt[i];
                        elemnt[i] = aux;
                    }
                }
            }
        }
    }
}