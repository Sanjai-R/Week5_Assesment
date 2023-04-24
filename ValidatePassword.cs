using System.Linq;
using System.Text.RegularExpressions;


namespace Problem
{
    public class ValidatePassword
    {
        public bool isValid(string password)
        {
            if (string.IsNullOrEmpty(password))
            {
                return false;
            }

            // Check length
            if (password.Length < 6 || password.Length > 24)
            {
                return false;
            }

            // Check uppercase letter
            if (!password.Any(char.IsUpper))
            {
                return false;
            }

            // Check lowercase letter
            if (!password.Any(char.IsLower))
            {
                return false;
            }

            // Check digit
            if (!password.Any(char.IsDigit))
            {
                return false;
            }

            // Check repeated characters
            if (Regex.IsMatch(password, @"(\w)\1{2,}"))
            {
                return false;
            }

            // Check special characters
            string specialCharacters = "!@#$%^&*()+=_-{}[]:;\"'<>?,.";
            if (!password.Any(c => specialCharacters.Contains(c)))
            {
                return false;
            }
            // All checks passed
            return true;
        }
    }
}