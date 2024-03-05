namespace VisitPlaner
{
    public class Visit
    {
        private Owner animalOwner;
        //private Patient animal;
        private DateTime todayDate;
        private string reasonVisit;

        public Visit(Owner animalOwner, DateTime date, string reasonVisit) 
        {
            AnimalOwner = animalOwner;
            this.todayDate = date;
            this.reasonVisit = reasonVisit;
        }

        public Owner AnimalOwner
        {
            get {  return animalOwner; }
            set { animalOwner = value; }
        }
        public DateTime TodayDate
        {
            get {  return todayDate; }
            set { todayDate = value; }
        }
        public string ReasonVisit
        {
            get { return reasonVisit; }
            set { reasonVisit = value; }
        }
        public override string ToString()
        {
            return $"Visit: {AnimalOwner},{TodayDate},{ReasonVisit}";
        }
    }
}
