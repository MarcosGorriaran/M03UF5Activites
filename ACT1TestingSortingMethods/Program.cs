using System.Collections;

namespace ACT1
{
    public class ACT1Driver
    {
        public static void Main()
        {
            Random rnd = new Random();
            List<Book> bookList = new List<Book>();
            bookList.Add(new Book());
            for(int i = 0; i < 4; i++)
            {
                bookList.Add(new Book(rnd.Next(0,10), rnd.Next(0,10),"Hello".Substring(rnd.Next(0,5))));
            }
            bookList.Sort();
            foreach(Book book in bookList)
            {
                Console.WriteLine(book);
            }
        }
    }
}