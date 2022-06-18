using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTask22.Models
{

    internal class Student : Person
    {
        private int _class;
        private int[] _evaluations;
        private int _studentId;
        public int Clazz
        {
            get { return _class; }
            set { _class = value; }
        }
        public int StudentId { get; set; }

        public int[] Evaluations
        {
            get { return _evaluations; }
            set
            {
                _evaluations = value;
            }
        }
        public int IsPass()
        {
            double averageRating = _evaluations.Sum() / _evaluations.Length;
            if (averageRating >= 3)
            {

                if (_class < 11)
                {

                    _class++;
                    Array.Clear(_evaluations);
                }
                else
                {
                    _class += _studentId;
                }
            }
            else
            {
                Array.Clear(_evaluations);
            }
            return _class;
        }

        public Student(char gender, string name, string firstName, DateTime birthday, int _class, int[] evaluations, int studentId) : base(gender, name, firstName, birthday)
        {
            Clazz = _class;
            _evaluations = evaluations;
            StudentId = studentId;
        }

        public Student() : this('-', "", "", DateTime.Now, 0, Array.Empty<int>(), 0)
        {

        }

        public override string ToString()
        {
            return $"{FullName}, Дата рождения: {Birthday:dd.MM.yyyy}, Пол: {Gender},Класс: {_class},Количество предметов: {_evaluations.Length}, Оценки: {string.Join(", ", _evaluations)}";
        }
    }
}
