using System;

namespace CalculatorConsoleApp
{
    internal class Calculator
    {
     
        internal static string Add(string firstValue, string secondValue)
        {
            decimal _firstDec, _secDec, _finalDec;
            bool _isFirstParsed, _isSecondParsed;
            Parse(firstValue, secondValue, out _firstDec, out _secDec, out _isFirstParsed, out _isSecondParsed);

            if (_isFirstParsed && _isSecondParsed)
            {

                _finalDec = _firstDec + _secDec;
                return "Addition = " + _finalDec.ToString();
            }
            else
            {
                return "Error parsing one of the decimals.";
            }
        }

        private static void Parse(string firstValue, string secondValue, out decimal _firstDec, out decimal _secDec, 
            out bool _isFirstParsed, out bool _isSecondParsed)
        {
            _isFirstParsed = decimal.TryParse(firstValue, out _firstDec);
            _isSecondParsed = decimal.TryParse(secondValue, out _secDec);
        }

        internal static string Subtract(string firstValue, string secondValue)
        {
            decimal _firstDec, _secDec, _finalDec;
            bool _isFirstParsed, _isSecondParsed;
            Parse(firstValue, secondValue, out _firstDec, out _secDec, out _isFirstParsed, out _isSecondParsed);

            if (_isFirstParsed && _isSecondParsed)
            {

                _finalDec = _firstDec - _secDec;
                return "Subtraction = " + _finalDec.ToString();
            }
            else
            {
                return "Error parsing one of the decimals.";
            }
        }

        internal static string Multiply(string firstValue, string secondValue)
        {
            decimal _firstDec, _secDec, _finalDec;
            bool _isFirstParsed, _isSecondParsed;
            Parse(firstValue, secondValue, out _firstDec, out _secDec, out _isFirstParsed, out _isSecondParsed);

            if (_isFirstParsed && _isSecondParsed)
            {

                _finalDec = _firstDec * _secDec;
                return "Multiply = " + _finalDec.ToString();
            }
            else
            {
                return "Error parsing one of the decimals.";
            }
        }

        internal static string Divide(string firstValue, string secondValue)
        {
            decimal _firstDec, _secDec, _finalDec;
            bool _isFirstParsed, _isSecondParsed;
            Parse(firstValue, secondValue, out _firstDec, out _secDec, out _isFirstParsed, out _isSecondParsed);

            if (_isFirstParsed && _isSecondParsed)
            {

                _finalDec = _firstDec % _secDec;
                return "Divide = " + _finalDec.ToString();
            }
            else
            {
                return "Error parsing one of the decimals.";
            }
        }
    }
}