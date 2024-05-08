

namespace Lab1 {

    public class Program
    {
        public static void Main() {

            try
            {
                University u1 = new University("Белорусский Государственный Университет");
                u1.Adress = "ул. Козыревская 22";
                Console.WriteLine(u1);
                Console.WriteLine(University.CountOfU);

                School school = new School("СШ #127 г. Минска", "ул. Сурганова 88");
                school.AddStudent("Вальчук Артём Сергеевич");
                school.AddStudent("Драч Кирилл Алексеевич");
                school.AddStudent("Голубин Глеб Геннадьевич");
                school.ShowPupils();
                school.isWorking = true;
                Console.WriteLine(school[2]);
                school.ShowGreetings();
                School school1 = new School("СШ #23 г. Бреста", "ул. Малая 37", new List<string>() {"Денис Другаков", "Павел Лудоманов",
                "Герман Фурионов" });
                school1.ShowPupils();

                NonGovLyseum ng1 = new NonGovLyseum("Лицей #1 г. Барановичи", 455, 7);
                ng1.SetSpecialization("Химия, Физика, Программирвание");
                ng1.ShowInfo();
                ng1.ChangeSpec("Биология, Математика, Иностранные языки");
                Console.WriteLine();

                Lyseum ls = new Lyseum("Артюх Эдуард Андреевич", 53);
                ls.SetSpecialization("Филологическое");
                ls.ShowInfo();

                school1.SchoolEvent += ls.OnSchoolEvent;
                school1.SchoolEvent += ng1.OnSchoolEvent;
                school1.StartEvent();


            }
            catch(Exception ex) {
                Console.WriteLine(ex.Message);
            }
        
        

        }
    }
}