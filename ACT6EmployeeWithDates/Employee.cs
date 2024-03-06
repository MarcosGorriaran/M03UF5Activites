namespace ACT6
{
    public class Employee
    {
        const int DefCode = 0;
        const string DefFirstName = "first";
        const string DefLastName = "last";
        const int DefAge = 0;
        const string DefSeniority = "Senior";
        const float DefAnualSalary = 2.48f;

        public Employee(int Code, string firstName, string lastName, int age, string seniority, float anualSalary) 
        {
            this.Code = Code;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Seniority = seniority;
            this.AnnualSalary = anualSalary;
        }
        public Employee() : this(DefCode, DefFirstName, DefLastName, DefAge, DefSeniority, DefAnualSalary)
        {
        
        }
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
                return $"{LastName} {FirstName}";
            }
        }
        public int Age { get; set; }
        public string Seniority { get; set; }
        public float AnnualSalary { get; set; }

        public void SetAgeTroughBirthDate(DateOnly birthDate)
        {
            DateOnly today = new DateOnly(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            int age;

            if (birthDate > today)
            {
                throw new Exception();
            }
            age = today.Year - birthDate.Year;
            if(today.Month < birthDate.Month)
            {
                age--;
            }else if(today.Day<birthDate.Day && today.Month == birthDate.Month)
            {
                age--;
            }
            this.Age = age;
        }
        public void SetAgeTroughBirthDate(string birthDate)
        {
            this.SetAgeTroughBirthDate (DateOnly.Parse(birthDate));
        }
    }
}
