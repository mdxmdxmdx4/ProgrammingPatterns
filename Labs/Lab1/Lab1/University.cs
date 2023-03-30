using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class University
    {
        public const string SPHERE = "EDUCATION";
        protected const double PAY_MULTIPL = 1.6;
        private const string GOV_CODE = "UNIV_RB_X001: ";
        private string _name;
        protected string _adress;
        public static int CountOfU;
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
        public string Adress {
            get {
                if (_adress != null)
                {
                    return _adress;
                }
                else throw new NullReferenceException();
                }
            set {
                if (value == null || value.Length <= 10) {
                    throw new ArgumentException();
                }
                _adress = value; 
            }
        }
        private int CalculateEduPrice() {
            return (int)((this.Id * 157 + 542) * PAY_MULTIPL);
        }
        public override string ToString()
        {
            return "[" + GOV_CODE + SPHERE + "] " + Name + " " + this.Adress;
        }
        public void ShowGreetings() {
            Console.WriteLine($"Поздравляем вас с поступлением в {this.Name}!\n" +
                $"Учебный корпус расположен по адресу: {this.Adress}\n" +
                $"Ваша стоимость обучения -{CalculateEduPrice()}");
        }
        protected void ShowInfo() {
            Console.WriteLine($"Кол-во студентов ={CountOfU}, множитель оплаты = {PAY_MULTIPL}") ;
        }
        static University()
        {
            CountOfU = 0;
        }
        public University(string name, string adress) {
        Name = name;
        Adress = adress;
        CountOfU++;
        Id = CountOfU;
        }
        public University(string name) {
        Name=name;
        CountOfU++;
        Id = CountOfU;
        }   
    }
}
