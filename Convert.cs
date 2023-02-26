

namespace Numeration_System
{
    public class Convert
    {

        public string ConvertNumberSystem(string number, int currentSystem, int targetSystem)
        {
            int decimalNumber = ConvertToDecimal(number, currentSystem);
            string result = ConvertFromDecimal(decimalNumber, targetSystem);
            return result;

        }

        public static int ConvertToDecimal(string number, int currentSystem)
        {
            int decimalNumber = 0;
            int power = 1;

            for (int i = number.Length - 1; i >= 0; i--)
            {
                int digit = GetDigitValue(number[i]);
                decimalNumber += digit * power;
                power *= currentSystem;
            }
            return decimalNumber;
        }

        public static int GetDigitValue(char digitChar)
        {
            if (char.IsDigit(digitChar))
            {
                return int.Parse(digitChar.ToString());
            }
            else
            {
                switch (digitChar)
                {
                    case 'A':
                    case 'a':
                        return 10;
                    case 'B':
                    case 'b':
                        return 11;
                    case 'C':
                    case 'c':
                        return 12;
                    case 'D':
                    case 'd':
                        return 13;
                    case 'E':
                    case 'e':
                        return 14;
                    case 'F':
                    case 'f':
                        return 15;
                    default:
                        throw new ArgumentException($"Incorrent digit character: {digitChar}");
                }
            }
        }

        public static string ConvertFromDecimal(int decimalNumber, int targetSystem)
        {
            string result = "";

            while (decimalNumber > 0)
            {
                int digit = decimalNumber % targetSystem;
                char digitChar = GetDigitChar(digit);
                result = digitChar + result;
                decimalNumber /= targetSystem;

            }
            return result;
        }

        public static char GetDigitChar(int digitValue)
        {
            if (digitValue < 10)
            {
                return char.Parse(digitValue.ToString());
            }
            else
            {
                switch (digitValue)
                {
                    case 10:
                        return 'A';
                    case 11:
                        return 'B';
                    case 12:
                        return 'C';
                    case 13:
                        return 'D';
                    case 14:
                        return 'E';
                    case 15:
                        return 'F';
                    default:
                        throw new ArgumentException($"Incorrect digit value: {digitValue}");
                }
            }
        }
    }
}
