using ACT6;

namespace ACT7
{
    public class SalesEmployee : Employee
    {
        const float DefComision = 18.00f;
        public SalesEmployee(int Code, string firstName, string lastName,
                            DateOnly birthDate,DateOnly hireDate, float monthSalary, int payment,
                            float comision):base(Code, firstName, lastName, birthDate,hireDate,monthSalary,payment) 
        {
            Comision = comision;
        }
        public SalesEmployee() : this(DefCode, DefFirstName, DefLastName, DateOnly.Parse(DefBirthDate),
                                DateOnly.Parse(DefHireDate), DefMonthSalary, DefPayments, DefComision)
        {

        }

        public float Comision {  get; set; }

        public override string ToString()
        {
            string showText = $">Comission: {Comision}";
            return base.ToString() + showText;
        }
    }
}
