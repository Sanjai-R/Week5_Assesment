using System.Linq;
using System.Text.RegularExpressions;


namespace Problem
{
    public class ValidatePassword
    {
        public static Action<dynamic> print = txt => Console.WriteLine(txt);

        public static bool isValid(string password)
        {
            if (string.IsNullOrEmpty(password))
            {
                print("Invalid password: Password cannot be empty");
                return false;
            }


            if (password.Length < 6 || password.Length > 24)
            {
                print("Invalid password: Password must be between 6 and 24 characters");
                return false;
            }


            if (!password.Any(char.IsUpper))
            {
                print("Invalid password: Password must contain at least one uppercase letter");
                return false;
            }


            if (!password.Any(char.IsLower))
            {
                print("Invalid password: Password must contain at least one lowercase letter");
                return false;
            }


            if (!password.Any(char.IsDigit))
            {
                print("Invalid password: Password must contain at least one digit");
                return false;
            }


            if (Regex.IsMatch(password, @"(\w)\1{2,}"))
            {
                print("Invalid password: Password cannot contain more than two of the same character in a row");
                return false;
            }


            string specialCharacters = "!@#$%^&*()+=_-{}[]:;\"'<>?,.";
            if (!password.Any(c => specialCharacters.Contains(c)))
            {
                print("Invalid password: Password must contain at least one special character");
                return false;
            }

            return true;
        }
    }
}