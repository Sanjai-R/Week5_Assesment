namespace Problem
{
    public class ValidName
    {
        public static bool isValid(string name)
        {
            // Split the name into terms by space
            string[] terms = name.Split();

            // Check if the name has 2 or 3 terms
            if (terms.Length < 2 || terms.Length > 3)
            {
                return false;
            }

            // Iterate through the terms and validate each term
            foreach (string term in terms)
            {
                if (term.Length == 1)
                {
                    // If term is an initial, it must end with a dot
                    if (!term.EndsWith('.'))
                    {
                        return false;
                    }
                }
                else if (term.Length >= 2)
                {
                    // If term is a word, it must not contain dots
                    if (term.Contains('.'))
                    {
                        return false;
                    }
                }
                else
                {
                    // Invalid term length
                    return false;
                }
            }

            // Check the last term, which should be a word
            if (terms[terms.Length - 1].Length <= 1)
            {
                return false;
            }

            // All validation checks passed, the name is valid
            return true;
        }
    }
}