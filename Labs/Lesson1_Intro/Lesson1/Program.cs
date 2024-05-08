

namespace Lesson1 {

    public class Program{
        public static void Main(string[] args)
        {
            try
            {
                Transport t1 = new Transport(13, "Судно");
                Car car1 = new Car(22, "Tesla", "Model S", 190);
                Console.WriteLine($"{t1.speed} || {car1.speed}\n");

                t1.ShowSpeed();
                car1.ShowSpeed();

                Transport t2 = new Car(33, "Mersedes", "AMG",200);
                t2.ShowSpeed();
                car1.Move();
                t2.Move();

                Car car2 = new Car(13, "BMW", "i8", 250);
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }

       }    

}

}