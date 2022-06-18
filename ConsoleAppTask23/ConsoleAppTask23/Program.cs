using ConsoleAppTask22.Models;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleAppTask22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine("=====ЧАСТЬ 1======");
            program.PartOne();
            Console.WriteLine("=====ЧАСТЬ 2======");
            program.PartTwo();
        }

        public void PartOne()
        {
            Worker person = new Worker('м', "Петя", "Пилюлькин", DateTime.Parse("12.01.1985"), 10000, 15, 2);
            person.Print();
            Console.WriteLine("====================================================");
            Console.WriteLine("Введите количество пользователей: ");
            int count = int.Parse(Console.ReadLine());
            Worker[] peoples = new Worker[count];
            InputWorkers(peoples);
            TaxSummary(peoples);
            CheckMaxSalary(peoples);
            OutputWorkers(peoples);
        }

        public void PartTwo()
        {
            List<Student> students = new List<Student>();
            InputStudents(students);
            OutputStudents(students);
        }

        private static Worker InputWorker()
        {
            Worker worker = new Worker();
            Console.Write("Введите имя: ");
            worker.Name = Console.ReadLine().Trim();
            Console.Write("Введите фамилию: ");
            worker.FirstName = Console.ReadLine().Trim();
            Console.Write("Введите дату рождения (dd.mm.yyyy)");
            worker.Birthday = DateTime.Parse(Console.ReadLine().Trim());
            Console.Write("Введите пол: (М/Ж)");
            worker.Gender = char.Parse(Console.ReadLine().Trim());
            Console.Write("Оклад: ");
            worker.Salary = double.Parse(Console.ReadLine().Trim());
            Console.Write("Стаж работы: ");
            worker.WorkExperience = double.Parse(Console.ReadLine().Trim());
            Console.Write("Процент премии: ");
            worker.Bonus = double.Parse(Console.ReadLine().Trim());
            return worker;
        }

        private static WorkerWithHourPay InputWorkerWithHourPay()
        {
            WorkerWithHourPay worker = new WorkerWithHourPay();
            Console.Write("Введите имя: ");
            worker.Name = Console.ReadLine().Trim();
            Console.Write("Введите фамилию: ");
            worker.FirstName = Console.ReadLine().Trim();
            Console.Write("Введите дату рождения (dd.mm.yyyy)");
            worker.Birthday = DateTime.Parse(Console.ReadLine().Trim());
            Console.Write("Введите пол: (М/Ж)");
            worker.Gender = char.Parse(Console.ReadLine().Trim());
            Console.Write("Оплата за час: ");
            worker.Salary = double.Parse(Console.ReadLine().Trim());
            Console.Write("Количество отработанных часов: ");
            worker.HoursWorked = double.Parse(Console.ReadLine().Trim());
            Console.Write("Процент премии: ");
            worker.Bonus = double.Parse(Console.ReadLine().Trim());
            return worker;
        }

        private static Student InputStudent()
        {
            Student student = new Student();

            Console.Write("Введите имя: ");
            student.Name = Console.ReadLine().Trim();
            Console.Write("Введите фамилию: ");
            student.FirstName = Console.ReadLine().Trim();
            Console.Write("Введите дату рождения (dd.mm.yyyy)");
            student.Birthday = DateTime.Parse(Console.ReadLine().Trim());
            Console.Write("Введите пол: (М/Ж)");
            student.Gender = char.Parse(Console.ReadLine().Trim());
            Console.Write("Введите класс ученика: ");
            student.Clazz = int.Parse(Console.ReadLine().Trim());
            Console.WriteLine("Введите количество предметов");
            int countLessons = int.Parse(Console.ReadLine().Trim());
            int[] evaluations = new int[countLessons];
            for (int i = 0; i < countLessons; i++)
            {
                Console.Write($"Введите оценку по {i + 1} предмету: ");
                evaluations[i] = int.Parse(Console.ReadLine().Trim());
            }
            student.Evaluations = evaluations;
            return student;
        }

        private static void TaxSummary(Worker[] peoples)
        {
            double SummaryTax = peoples[0].TaxCheck();
            for (int i = 1; i < peoples.Length; i++)
            {
                SummaryTax += peoples[i].TaxCheck();
            }
            Console.WriteLine($"Сумма налогов: {SummaryTax}");
        }

        private static void CheckMaxSalary(Worker[] peoples)
        {
            string FirstNameOfBestWorker = peoples[0].FirstName;

            for (int i = 1; i < peoples.Length; i++)
            {

                if (peoples[i].Salary > peoples[i - 1].Salary)
                {
                    FirstNameOfBestWorker = peoples[i].FirstName;
                }
            }
            Console.WriteLine($"Работник с большей зарплатой: {FirstNameOfBestWorker}");
        }

        private static void InputWorkers(Worker[] peoples)
        {
            ConsoleKey consoleKeyY = ConsoleKey.Y;
            ConsoleKey consoleKeyN = ConsoleKey.N;
            for (int i = 0; i < peoples.Length; i++)
            {
                Console.WriteLine("Какого работника вы хотите добавить? Y - с почасовой оплатой, N - с месячной оплатой");
                if (Console.ReadKey(true).Key == consoleKeyY)
                {
                    peoples[i] = InputWorkerWithHourPay();
                }
                else if (Console.ReadKey(true).Key == consoleKeyN)
                {
                    peoples[i] = InputWorker();
                }
            }
        }
        private static void InputStudents(List<Student> students)
        {
            ConsoleKey consoleKey = ConsoleKey.Y;
            while (consoleKey == ConsoleKey.Y)
            {
                students.Add(InputStudent());
                Console.WriteLine("Добавить нового ученика? Нажмите Y - да,  любая кнопка чтобы продолжить");

                consoleKey = Console.ReadKey(true).Key;
            }
        }

        private static void OutputWorkers(Worker[] peoples)
        {

            Array.Sort(peoples);
            for (int i = 0; i < peoples.Length; i++)
            {

                peoples[i].Print();
            }
        }
        private static void OutputStudents(List<Student> students)
        {
            students.ForEach(student => { student.IsPass(); Console.WriteLine(student); });
        }
    }
}