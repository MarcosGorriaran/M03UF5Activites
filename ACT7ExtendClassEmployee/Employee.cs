namespace ACT6
{
    public class Employee : IComparable<Employee>
    {
        protected const int DefCode = 0;
        protected const string DefFirstName = "first";
        protected const string DefLastName = "last";
        protected const string DefBirthDate = "01/01/1970";
        protected const string DefHireDate = "01/01/1970";
        protected const float DefMonthSalary = 1800f;
        protected const int DefPayments = 14;
        
        public Employee(int Code, string firstName, string lastName, DateOnly birthDate,DateOnly hireDate, float monthSalary, int payments) 
        {
            this.Code = Code;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.BirthDate = birthDate;
            this.MonthSalary = monthSalary;
            this.payments = payments;
        }
        public Employee() : this(DefCode, DefFirstName, DefLastName, DateOnly.Parse(DefBirthDate),DateOnly.Parse(DefHireDate), DefMonthSalary, DefPayments)
        {
        
        }
        public int Code {  get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName() 
        {
            
            return $"{FirstName} {LastName}";
            
        }
        public string ReverseName()
        {
            
           return $"{LastName} {FirstName}";
            
        }
        public int employmentContractLength()
        {
            DateOnly today = new DateOnly(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            int age;


            age = today.Year - this.HireDate.Year;
            if (today.Month < this.HireDate.Month)
            {
                age--;
            }
            else if (today.Day < this.HireDate.Day && today.Month == this.HireDate.Month)
            {
                age--;
            }
            return age;
        }
        public float GetAnualSalary()
        {
            return MonthSalary * payments;
        }
        public DateOnly BirthDate { get; set; }
        public DateOnly HireDate { get; set; }
        public float MonthSalary { get; set; }
        public int payments {  get; set; }

        public int GetAge()
        {
            DateOnly today = new DateOnly(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            int age;

            
            age = today.Year - this.BirthDate.Year;
            if(today.Month < this.BirthDate.Month)
            {
                age--;
            }else if(today.Day<this.BirthDate.Day && today.Month == this.BirthDate.Month)
            {
                age--;
            }
            return age;
        }
        public override string ToString()
        {
            const string ClassName = "EMPLOYEE";
            const char Line = '-';
            const char WhiteSpace = ' ';
            string showText = new string(Line, Console.WindowWidth)+ Environment.NewLine;
            int centerCalc=Console.WindowWidth/2-(ClassName.Length/2);
            showText += new string(WhiteSpace, centerCalc)+ClassName+new string(WhiteSpace,centerCalc)+ Environment.NewLine;
            showText += new string(Line, Console.WindowWidth) + Environment.NewLine;

            showText += $">Code: {this.Code}{Environment.NewLine}";
            showText += $">Firstname: {this.FirstName}{Environment.NewLine}";
            showText += $">Lastname: {this.LastName} {Environment.NewLine}";
            showText += $">Fullname: {this.FullName()}{Environment.NewLine}";
            showText += $">Reverse name: {this.ReverseName()} {Environment.NewLine}";
            showText += $">Age: {this.GetAge()} {Environment.NewLine}";
            showText += $">Seniority: {this.employmentContractLength()} {Environment.NewLine}";
            showText += $">Annual salary: {this.GetAnualSalary()} {Environment.NewLine}";
            return showText;
        }
        public int CompareTo(Employee otherEmployee)
        {
            return this.
        }
    }
}
