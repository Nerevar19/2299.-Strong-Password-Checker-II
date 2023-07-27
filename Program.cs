namespace _2299._Strong_Password_Checker_II
{
    internal class Program
    {
        static public bool StrongPasswordCheckerII(string password)
        {
            return IsLeastAmount(password) && HasLowercase(password) && HasUppercase(password) && HasDigit(password) && HasSpecial(password) && IsNotAdjacent(password);

        }
        static public bool IsLeastAmount(string password)
        {
                    return password.Length > 7;

        }
        static public bool HasLowercase(string password)
        {
            foreach (var ch in password)
            {
                if (char.IsLower(ch)) return true;
            }
            return false;
        }
        static public bool HasUppercase(string password)
        {
            foreach (var ch in password)
            {
                if (char.IsUpper(ch)) return true;
            }
            return false;
        }
        static public bool HasDigit(string password)
        {
            foreach (var ch in password)
            {
                if (char.IsDigit(ch)) return true;
            }
            return false;
        }
        static public bool HasSpecial (string password)
        {
            string special = "!@#$%^&*()-+";
            foreach (var ch in password)
            {
                if(special.Contains(ch)) return true;
            }
            return false;
        }
        static public bool IsNotAdjacent(string password)
        {
            for(int i = 0; i < password.Length - 1; i++)
            {
                if (password[i] == password[i + 1]) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}