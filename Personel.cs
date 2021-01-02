using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S_CupCoffee
{
    public class Personel
    {
        public string Name;
        public string Surname;
        public int Age;
        public int workTime;
        public decimal salary;
        public Personel()
        {
            getPersonelAge();
        }
        public Personel(string n, string s, int a, int w, decimal sa)
        {
            Name = n;
            Surname = s;
            Age = a;
            workTime = w;
            salary = sa;
        }
        public virtual decimal CalculateSalary()
        {
            return salary;
        }
        public override string ToString()
        {
            return Name + "-" + Surname + "-" + Age + "-" + workTime + "-" + CalculateSalary();
        }
        public int getPersonelAge()
        {
            return Age;
        }
    }
    public class Manager : Personel
    {
        public decimal managerBonus;
        public Manager(string n, string s, int a, int w, decimal sa, decimal mb) : base(n, s, a, w, sa)
        {
            managerBonus = mb;
        }
        public override decimal CalculateSalary()
        {
            return salary + managerBonus;
        }
        public override string ToString()
        {
            return "Manager: " + Name + "-" + Surname + "-" + Age + "-" + workTime + "-" + CalculateSalary();
        }
    }
    public class Worker : Personel
    {
        public decimal workerBonus;
        public Worker(string n, string s, int a, int w, decimal sa, decimal wb) : base(n, s, a, w, sa)
        {
            workerBonus = wb;
        }
        public override decimal CalculateSalary()
        {
            return workerBonus + salary;
        }
        public override string ToString()
        {
            return "Worker: " + Name + "-" + Surname + "-" + Age + "-" + workTime + "-" + CalculateSalary();
        }
    }
}
