namespace Problem
{
    public class ValidName
    {
        public static Action<dynamic> print = txt => Console.WriteLine(txt);
        public static bool isValid(string name)
        {
            string[] terms = name.Split();

            if (terms.Length < 2 || terms.Length > 3)
            {
                print("Invalid name: Must have 2 or 3 terms");
                return false;
            }
            foreach (var i in terms)
            {
                print(i.Length);

            }

            foreach (string term in terms)
            {
                if (term.Length == 1 && !term.EndsWith('.'))
                {

                    print("Invalid name: Initial must end with a dot");
                    return false;
                }
                else if (term.Length >= 2 && term.Contains('.') && char.IsLower(term[0]))
                {

                    print("Invalid name: Incorrect capitalization");
                    return false;
                }
                else if (term.Length > 2 && term.Contains('.'))
                {


                    print("Invalid name: Word cannot contain dots");
                    return false;
                }
                else if (term.Length <= 1)
                {

                    print("Invalid name: Term must have 2 or more characters");
                    return false;
                }
                else if ((terms[0] == term || terms[1] == term) && term.EndsWith("."))
                {
                    print("Invalid name: cannot keep the first name as an initial");
                    return false;
                }
            }
            if (terms[terms.Length - 1].Length <= 1)
            {
                print("Invalid name: Last term must be a word");
                return false;
            }

            return true;
        }
    }
}