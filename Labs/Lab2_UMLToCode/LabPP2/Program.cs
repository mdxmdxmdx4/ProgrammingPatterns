using System;

namespace LabPP2
{
    class Program
    {
        static void Main(string[] args)
        {

            University university = new University("БГТУ", "Свердлова 13", typeof(string));
            Faculty faculty = new Faculty("ФИТ", "Свердлова 13А, к.1", typeof(string));
            Faculty faculty1 = new Faculty("ХТиТ", "Свердлова 13, к. 4", typeof(string));
            Faculty faculty2 = new Faculty("КБ", "Сурганова 55", typeof(string));

            JobTitle jobTitle = new JobTitle();
            jobTitle.Title = "Преподаватель физики";
            Department department = new Department();
            department.DepTitle = "Кафедра физики";

            university.PrintInfo();

            university.AddFaculty(faculty);
            university.AddFaculty(faculty1);
            university.AddFaculty(faculty2);

            university.AddJobTitle(jobTitle);
            university.Dismiss(new Reason("Прогулы"));
            foreach(var el in university.GetFaculties()){
                Console.WriteLine(el);
            }

            faculty.AddDepartment(department);
            faculty.AddJobTitle(jobTitle);

            faculty.Dismiss(new Reason("Nothing"));






        }
    }
}
