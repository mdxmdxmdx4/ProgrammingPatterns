using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class NonGovLyseum : Lyseum
    {
        private int numOfDisciplines;
        public int NumOfDisciplines {
            get { return numOfDisciplines; }
            set {
                if (value >= 2)
                    numOfDisciplines = value;
                else
                    throw new ArgumentException("numOfDisciplines");
            }
        }
        public NonGovLyseum(string dir, int st, int numOfDisciplines) : base(dir, st)
        {
            this.numOfDisciplines = numOfDisciplines;

        }
        new public void ShowInfo() { 
        base.ShowInfo();
            Console.WriteLine($"Кол-во цисциплин = {numOfDisciplines}");
        }
        public void ChangeSpec(string str) {
            if (str != null && str.Length > 0 && this.specialization != null)
                this.specialization = str;
            Console.WriteLine($"Cпециализация изменена на {str}");
        }
    }
}
