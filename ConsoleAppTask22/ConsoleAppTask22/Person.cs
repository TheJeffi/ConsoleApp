using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTask22
{
    public class Person : IComparable
    {
        private char _gender;
        public string Name { get; set; }
        public string FirstName { get; set; }
        public DateTime Birthday { get; set; }

        public string FullName => $"{FirstName} {Name}";
        public char Gender
        {
            get => _gender;
                set
            {
                if (value == 'м' || value == 'ж')
                {
                    _gender = char.ToUpper(value);
                }
                else _gender = '-';
            }
        }

        public Person(char gender, string name, string firstName, DateTime birthday)
        {
            Gender = gender;
            Name = name;
            FirstName = firstName;
            Birthday = birthday;
        }
        public Person(string name, string firstName):this('-',name,firstName,DateTime.Now) { }

        public Person():this('-',"","",DateTime.Now)
        {
            
        }

        public Person(Person previousPerson):this(previousPerson.Gender,  previousPerson.Name, previousPerson.FirstName, previousPerson.Birthday) { }

        public int Age
        {
            get 
            {
                int a = DateTime.Today.Year - Birthday.Year;
                if (DateTime.Today.DayOfYear < Birthday.DayOfYear)
                {
                    a--;
                }
                return a;
            }
        }

        public void Print()
        {
            Console.WriteLine("Данные пользователя: " + FullName + " Возраст: " + Age + " Пол: " + Gender);
        }

        public virtual int CompareTo(object? obj)
        {
            throw new NotImplementedException();
        }
    }
}
