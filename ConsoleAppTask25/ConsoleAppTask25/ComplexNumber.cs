using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleAppTask25
{
    internal class ComplexNumber
    {
        private double _imaginaryNumber;
        private double _realNumber;

        public double ImaginaryNumber { get { return _imaginaryNumber; } set { _imaginaryNumber = value; } }
        public double RealNumber { get { return _realNumber; } set { _realNumber = value; } }

        public string ComplexNumberValue { get { return $"{_realNumber}+i{_imaginaryNumber}"; } 
            set
            {
                Regex stringParse = new Regex(@"^(\-)?(\d+)\s?(\+|\-)\s?i(\d+)$");
                Match match = stringParse.Match(value);
                if (match.Groups.Count >= 3)
                {   
                    RealNumber = GetParseNumber(match.Groups[1].Value, match.Groups[2].Value);
                    ImaginaryNumber = GetParseNumber(match.Groups[3].Value, match.Groups[4].Value);
                }
            } 
        }

        public ComplexNumber() : this(0, 0) { }
        public ComplexNumber(double _realNumber,double _imaginaryNumber)
        {
            ImaginaryNumber = _imaginaryNumber;
            RealNumber = _realNumber;
        }

        public override string ToString()
        {
            return $"Действительная часть числа {_realNumber}, мнимая часть числа {_imaginaryNumber}, комплексное число {GetCompleteNumber()}, модуль числа {GetComplexNumberModule()}";
        }

        public double GetComplexNumberModule()
        {
            return Math.Round(Math.Sqrt(Math.Pow(RealNumber,2)+ Math.Pow(ImaginaryNumber, 2)),3);
        }

        private double GetParseNumber(string symbol, string number)
        {
            return (symbol == "-")?double.Parse(number)*(-1) : double.Parse(number);
        }
        private string GetCompleteNumber()
        {
            return ($"{_realNumber}{(_imaginaryNumber<0?"-":"+")}i{Math.Abs(_imaginaryNumber)}");
        }
        public override bool Equals(object? obj)
        {
            return obj is ComplexNumber number ? _realNumber == number.RealNumber && _imaginaryNumber == number.ImaginaryNumber : false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public ComplexNumber Sum(ComplexNumber number)
        {
           double realNumber = number.RealNumber + _realNumber;
           double imaginaryNumber = number.ImaginaryNumber + _imaginaryNumber;
           return new ComplexNumber(realNumber, imaginaryNumber);
        }

        public ComplexNumber Subtract(ComplexNumber number)
        {
            double realNumber = number.RealNumber - _realNumber;
            double imaginaryNumber = number.ImaginaryNumber - _imaginaryNumber;
            return new ComplexNumber(realNumber, imaginaryNumber);
        }

        public ComplexNumber Multiply(ComplexNumber number)
        {
            double realNumber = _realNumber*number.RealNumber - _imaginaryNumber*number.ImaginaryNumber;
            double imaginaryNumber = _realNumber * number.ImaginaryNumber +_imaginaryNumber * number.RealNumber;
            return new ComplexNumber(realNumber, imaginaryNumber);
        }
        public ComplexNumber Divide(ComplexNumber number)
        {   
            double realNumber = (_realNumber*number.RealNumber + _imaginaryNumber*number.ImaginaryNumber)/(Math.Pow(number.RealNumber,2)+ Math.Pow(number.ImaginaryNumber,2));
            double imaginaryNumber = (_imaginaryNumber * number.RealNumber - _realNumber * number.ImaginaryNumber) / (Math.Pow(number.RealNumber, 2) + Math.Pow(number.ImaginaryNumber, 2));
            return new ComplexNumber(realNumber, imaginaryNumber);
        }

    }
}
