namespace VisitPlaner
{
    public class Owner
    {
        private string dni;
        private string name="";

        public Owner(string dni, string name)
        {
            Dni = dni;
            Name = name;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        public override string ToString()
        {
            return $"Owner: {Name}, {Dni}";
        }
    }
}
