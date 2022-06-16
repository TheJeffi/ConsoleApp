namespace ConsoleAppTask22
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите количество пользователей: ");
            int count = int.Parse(Console.ReadLine());
            Worker[] peoples = new Worker[count];

            Worker person = new Worker('м', "Петя", "Пилюлькин", DateTime.Parse("12.01.1985"), 10000, 15, 2);
            person.Print();


            InputWorkers(peoples);
            TaxSummary(peoples);
            CheckMaxSalary(peoples);
            OutputWorkers(peoples);
        }
        public static Worker InputWorker()
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

        public static WorkerWithHourPay InputWorkerWithHourPay()
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

        public static void TaxSummary(Worker[] peoples)
        {
            double SummaryTax = peoples[0].TaxCheck();
            for (int i = 1; i < peoples.Length; i++)
            {
                SummaryTax += peoples[i].TaxCheck();
            }
            Console.WriteLine($"Сумма налогов: {SummaryTax}");
        }

        public static void CheckMaxSalary(Worker[] peoples)
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

        public static void InputWorkers(Worker[] peoples)
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

        public static void OutputWorkers(Worker[] peoples)
        {

            Array.Sort(peoples);
            for (int i = 0; i < peoples.Length; i++)
            {

                peoples[i].Print();
            }
        }
    }
}