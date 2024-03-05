namespace ACT1
{
    public class Book : IComparable<Book>
    {
        const int DefID = 0;
        const int DefNumPages = 0;
        const string DefTitle = "Title";
        private int id;
        private int numPages;
        private string title;

        public int CompareTo(Book? obj)
        {
            int result = this.numPages.CompareTo(obj.numPages);
            if(result == 0)
            {
                result = this.Title.CompareTo(obj.title);
            }
            return result;
        }
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public int NumPages
        {
            get { return numPages; }
            set { numPages = value; }
        }
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public Book(int id, int numPages, string title)
        {
            ID = id;
            NumPages = numPages;
            Title = title;
        }

        public Book() : this(DefID, DefNumPages, DefTitle)
        {

        }

        public override string ToString()
        {
            return $"{ID}, {NumPages}, {Title}";
        }

        
    }
}
