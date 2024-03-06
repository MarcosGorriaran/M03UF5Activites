using ACT6;
namespace ACT7
{
    public class SalesEmployee : Employee
    {
        const float DefComision = 3.00f;
        public SalesEmployee(int Code, string firstName, string lastName,
                            int age, string seniority, float anualSalary,
                            float comision):base(Code, firstName, lastName, age, seniority, anualSalary) 
        {
            Comision = comision;
        }
        public SalesEmployee() : this(DefCode, DefFirstName, DefLastName, DefAge, DefSeniority, DefAnualSalary, DefComision)
        {

        }

        public float Comision {  get; set; }
    }
}
