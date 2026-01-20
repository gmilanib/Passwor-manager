
using System;

namespace passwordManager
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Comprimento da Senha:
            Console.WriteLine("Enter the desired password length:");
            int length = int.Parse(Console.ReadLine());

            //Has Special Characters?
            Console.WriteLine("Should the password include special characters? (yes/no):");
            bool hasSpecialChar = Console.ReadLine().ToLower() == "yes";

            //Has Numbers?
            Console.WriteLine("Should the password include numbers? (yes/no):");
            bool hasNumbers = Console.ReadLine().ToLower() == "yes";

            //Has Uppercase?
            Console.WriteLine("Should the password include uppercase letters? (yes/no):");
            bool hasUppercase = Console.ReadLine().ToLower() == "yes";

            //Has Lowercase?
            Console.WriteLine("Should the password include lowercase letters? (yes/no):");
            bool hasLowercase = Console.ReadLine().ToLower() == "yes";

            passWord myPassword = new passWord(length, hasSpecialChar, hasNumbers, hasUppercase, hasLowercase);
            Console.WriteLine("****************************");
            Console.WriteLine("Generating password...");
            Console.WriteLine("Generated Password: " + myPassword.generatePassword());
            Console.WriteLine("****************************");
            Console.WriteLine("Is the password strong? " + myPassword.isStrong());
        }
    }
}