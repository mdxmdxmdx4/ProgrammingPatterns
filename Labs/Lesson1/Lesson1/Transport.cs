using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    public class Transport : IMovable
    {
        public int speed;
        public int mark;
        public string title;
        public Transport(int mark, string title)
        {
            speed = 0;
            this.title = title;
        }

        public void Move()
        {
            Console.WriteLine("Транспорт пришёл в движение!\n");
        }

        public virtual void ShowSpeed() {
            Console.WriteLine($"Скорость данного транспорта = {this.speed}\n");
        }

    }
}
