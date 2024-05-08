namespace Lab1
{
    public class Lyseum
    {
        protected static string director;
        public string Director
        {
            get { return director; }
            protected set { director = value; }
        }
        protected int numOfStidents;
        public int NumOfStudents
        {
            get { return numOfStidents; }
            protected set
            {
                if (value <= 10)
                    throw new ArgumentException();
                numOfStidents = value;
            }
        }
        protected string specialization;
        protected int ratio;
        private bool IsSupportingBySponsors = false;
        public Lyseum(string dirFIO, int studNum)
        {
            Director = dirFIO;
            NumOfStudents = studNum;
            ratio = CalcRatio();
        }
        private int CalcRatio() {
            return NumOfStudents / 85;
        }
        public void SetSpecialization(string spec) {
            if (spec != null && spec.Length > 0 && this.specialization == null)
                this.specialization = spec;
        }
        public void ShowInfo(){
            Console.WriteLine($"Директор УО {this.Director}. Лицей обучает {this.NumOfStudents} учеников");
        }

        public void OnSchoolEvent() {
            Console.WriteLine("Событие произйдёт на территории школы!");
        }
    }
}
