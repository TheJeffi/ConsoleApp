using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTask22
{
    internal class WorkerWithHourPay : Worker
    {

        public double HoursWorked { get; set; }

        public override double PayCheck()
        {
            double resultSalary = 0;
            resultSalary = Salary * HoursWorked;
            resultSalary -= TaxCheck();
            if (WorkExperience > 10)
            {
                Bonus *= 2;
            }
            return HasBonus ? (resultSalary * Bonus) + resultSalary : resultSalary;
        }

        public double TaxCheck()
        {
            double tax = Salary * 0.13;
            return tax;
        }

        public WorkerWithHourPay(double hoursWorked):base() 
        {
            HoursWorked = hoursWorked;
        }

        public WorkerWithHourPay() { }

        public void Print()
        {
            Console.WriteLine("Данные пользователя: " + FullName + " Оплата за час: " + Salary + " Кол-во часов: " + HoursWorked + " Итог: " + PayCheck());
        }
    }
}
