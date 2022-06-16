using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTask22
{
    internal class Worker : Person
    {
        public double Salary { get; set; }

        private double _bonus;
        public double Bonus
        {
            get { return _bonus; }
            set
            {
                if (value < 0 || value > 100)
                {
                    _bonus = 0;
                    Console.WriteLine("Неверно указан % премии. Установлено значение: 0%");
                }
                _bonus = value / 100;
            }
        }

        public bool HasBonus => _bonus > 0;
        public double WorkExperience { get; set; }

        public Worker() : this('-',"","",DateTime.Now,0,0,0) { }

        public Worker(double salary, double bonus, double workExperience) : this('-',"","",DateTime.Now, salary, bonus, workExperience) { }
        public Worker(string name, string firstName, double salary, double bonus, double workExperience) : this('-',name,firstName, DateTime.Now, salary,bonus,workExperience) { }

        public Worker(char gender, string name, string firstName, DateTime birthday, double salary, double bonus, double workExperience) : base(gender, name, firstName, birthday)
        {
            Salary = salary;
            Bonus = bonus;
            WorkExperience = workExperience;
        }

        public virtual double PayCheck()
        {
            Salary -= TaxCheck();
            if (WorkExperience > 10)
            {
                _bonus *= 2;
            }
            return HasBonus ? (Salary * Bonus) + Salary : Salary;
        }

        public virtual double TaxCheck()
        {
            double tax = Salary * 0.13;
            return tax;
        }

        public void Print()
        {
            Console.WriteLine("Данные пользователя: " + FullName + " Стаж работы: " + WorkExperience + " Оклад: " + Salary + " Итог: " + PayCheck());
        }

        public override int CompareTo(object? obj)
        {
            return (obj is Worker worker) ? Salary.CompareTo(worker.Salary) : throw new ArgumentException("Incorrect object type");
        }
    }
}
