namespace Lab1
{
    public class School : ISchool
    {
        private List<string> _pupils = new List<string>();
        public void AddStudent(string str)
        {
            if (str == null || str.Length <= 10)
                throw new ArgumentException("str");
            _pupils.Add(str);
        }
        public void ShowPupils()
        {
            foreach (string str in _pupils)
            {
                Console.WriteLine(str);
            }
        }
        public string this[int indexer]
        {
            get
            {
                if (indexer >= 0 && indexer < _pupils.Count)
                    return _pupils.ToArray().ElementAt(indexer);
                else return "WRONG ARGUMENT";
            }
        }

        public bool isWorking
        {
            get;
            set;
        }

        public event SomeEvent SchoolEvent;

        public const string SPHERE = "EDUCATION";
        protected const double PAY_MULTIPL = 0;
        private const string GOV_CODE = "RB_SCHOOL_02x: ";
        private string _name;
        protected string _adress;
        public static int CountOfU = 0;
        private int Id
        {
            get;
            set;
        }
        protected string Name
        {
            get
            {
                return _name;
            }
            private set
            {
                if (value == null || value.Length <= 10)
                {
                    throw new ArgumentException("name");
                }
                _name = value;
            }
        }
        public string Adress
        {
            get;
            set;
        }
        private int CalculateEduPrice()
        {
            return 0;
        }
        public override string ToString()
        {
            return "[" + GOV_CODE + SPHERE + "]" + this.Name + " " + this.Adress;
        }
        public void ShowGreetings()
        {
            Console.WriteLine($"\n" +
                $"Поздравляем вас с поступлением в {this.Name}!\n" +
                $"Учебный корпус расположен по адресу: {this.Adress}\n" +
                $"Ваша стоимость обучения = {CalculateEduPrice()}");
        }
        public School(string name) {
            Name = name;
        }
        public School(string name, string adress)
        {
            Name = name;
            Adress = adress;
            CountOfU++;
            Id = CountOfU;
        }
        public School(string name, string adress, List<string> ppls)
        {
            Name = name;
            Adress = adress;
            CountOfU++;
            Id = CountOfU;
            if (ppls.Count >= 1)
                _pupils = ppls;
        }
        public void StartEvent() {
            Console.WriteLine("Мероприятине началось!");
            SchoolEvent.Invoke();
        }

    }
}
