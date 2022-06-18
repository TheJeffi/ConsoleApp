namespace ConsoleAppTask25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.PartOne();
            program.PartTwo();
        }

        public void PartOne()
        {
            ComplexNumber number1 = new ComplexNumber();
            Input(number1);
            
            ComplexNumber number2 = new ComplexNumber(4,3);

            ComplexNumber number3 = new ComplexNumber(_realNumber: 2, _imaginaryNumber: -2);

            number1.RealNumber *= 3;
            number2.ImaginaryNumber -= 2;
            number3.RealNumber += 10;
            number3.ImaginaryNumber *= 10;

            Console.WriteLine($"{number1}, Модуль комплексного числа = {number1.GetComplexNumberModule()}");

            Console.WriteLine($"{number2}, Модуль комплексного  числа = {number2.GetComplexNumberModule()}");

            Console.WriteLine($"{number3}, Модуль комплексного  числа = {number3.GetComplexNumberModule()}");

            ComplexNumber number4 = new ComplexNumber(_realNumber: 2, _imaginaryNumber: 2);

            ComplexNumber number5 = new ComplexNumber(_realNumber: 2, _imaginaryNumber: 2);

            ComplexNumber number6 = new ComplexNumber(_realNumber: 2, _imaginaryNumber: -2);

            Console.WriteLine(number6.Equals(number5));

            Console.WriteLine(number4.Equals(number5));
        }

        public void PartTwo()
        {
            ComplexNumber number = new ComplexNumber(-3, 4);
            ComplexNumber number2 = new ComplexNumber();
            Input(number2);

            Console.WriteLine($"Сумма первого и второго комплексных чисел = {number.Sum(number2)}");
            Console.WriteLine($"Разность первого и второго комплексных чисел = {number.Subtract(number2)}");
            Console.WriteLine($"Произведение первого и второго комплексных чисел = {number.Multiply(number2)}");
            Console.WriteLine($"Частное первого и второго комплексных чисел = {number.Divide(number2)}");
            Console.WriteLine($"Сумма произведения первого и второго чисел и их частного = {number.Multiply(number2).Sum(number.Divide(number2))}");


        }
        public void Input(ComplexNumber number)
        {
            Console.WriteLine("Введите комплексное число: (a+ib)");
            number.ComplexNumberValue = Console.ReadLine()!.Trim();
        }
    }
}