namespace ACT6
{
    public class Employee
    {
        public int Code {  get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName 
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
        public string ReverseName
        {
            get
            {
                return $"{FirstName} {LastName}".Reverse("".ToCharArray());
            }
        }
        public int Age { get; set; }
    }
}
