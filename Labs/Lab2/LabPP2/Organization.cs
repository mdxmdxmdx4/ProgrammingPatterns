using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabPP2
{
    public class Organization : IStaff
    {
        public int Id { get; private set; }
        public string Name { get; protected set; }
        public Type ShortName { get; protected set; }
        public string Address { get; protected set; }
        public DateTime TimeStamp { get; protected set; }

        public Organization()
        {

        }

        public Organization(Organization organization)
        {
            Name = organization.Name;
            ShortName = organization.ShortName;
            Address = organization.Address;
        }

        public Organization(string _name, string address, Type shortName)
        {
            Name = _name;
            ShortName = shortName;
            Address = address;
        }

        public void PrintInfo()
        {
            Console.WriteLine(this.Name);
            Console.WriteLine(this.ShortName);
            Console.WriteLine(this.Address);
        }

        public List<JobVacancy> GetJobVacancies()
        {
            Console.WriteLine("Метод не имеет смысла(формально)");
            List<JobVacancy> jobs = new List<JobVacancy>();
            return jobs;
        }

        public int OpenJobVacancy(JobVacancy jobVacancy)
        {
            throw new NotImplementedException();
        }

        public bool CloseJobVacancy(int index)
        {
            Console.WriteLine($"Вакансия #{index} закрыта");
            return true;
        }

        public int AddJobTitle(JobTitle jobTitle)
        {
            Console.WriteLine($"Свободная должность - {jobTitle.Title}");
            return 0;
        }

        public bool DelJobTitle(int index)
        {
            Console.WriteLine("Должность удалена");
            return true;
        }

        public Emploee Recruit(JobVacancy job, Person person)
        {
            throw new NotImplementedException();
        }

        public void Dismiss(Reason reason)
        {
            Console.WriteLine($"Увольнение по причине {reason.ToString()}");
        }

        public List<Emploee> getEmployees()
        {
            Console.WriteLine("Метод должен возвращать всех сотрудников");
            return new List<Emploee>();
        }

        public List<JobTitle> getJobTitles() {

            Console.WriteLine("Метод должен вернуть описания должностей");
            return new List<JobTitle>();
        }

        public string printJobVacansies()
        {
            return "Вакансия ###";
        }
    }
}
