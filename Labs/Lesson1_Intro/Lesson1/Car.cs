using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    public class Car : Transport, IMovable
    {
        private string _model;
        public string Model {
            get { return _model; }
            set {
                if (value == null || value == "i8")
                    throw new Exception("Incorrect Model");
                _model = value;
            }
        }
        public Car(int mark, string title, string model, int speed) : base(mark, title)
        {
            this.Model = model;
            this.speed = speed;
        }

        public void Move()
        {
            Console.WriteLine($"Автомобиль {this.title} {this.Model} пришёл в движение!\n") ;
        }

        public override void ShowSpeed()
        {
            Console.WriteLine($"Скорость \"{this.title} {this.Model}\" = {this.speed}\n");
        }
        
    }
}
