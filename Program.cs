namespace Problem
{
    class Program
    {
        static void Main(string[] args)
        {

            int input;
            while (true)
            {
                Console.WriteLine("Enter 1 to validate a password, \nEnter 2 to validate a name, \nEnter 3 to quit:");
                if (int.TryParse(Console.ReadLine(), out input))
                {
                    switch (input)
                    {
                        case 1:
                            Console.WriteLine("Enter a password to validate:");
                            string password = Console.ReadLine();
                            bool isValidPassword = ValidatePassword.isValid(password);
                            Console.WriteLine($"Is valid password? {isValidPassword}");
                            break;
                        case 2:
                            Console.WriteLine("Enter a name to validate:");
                            string name = Console.ReadLine();
                            bool isValidName = ValidName.isValid(name);
                            Console.WriteLine($"Is valid name? {isValidName}");
                            break;
                        case 3:
                            Console.WriteLine("Goodbye!");
                            return;
                        default:
                            Console.WriteLine("Invalid input. Please try again.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again.");
                }
            }
        }
    }
}