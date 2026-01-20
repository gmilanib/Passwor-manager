namespace passwordManager
{
    public class passWord
    {

        //Atributes
        public int length {get; set;}
        public bool hasSpecialChar {get; set;}
        public bool hasNumbers {get; set;}
        public bool hasUppercase {get; set;}
        public bool hasLowercase {get; set;}
        
        //Constructor
        public passWord(int length, bool hasSpecialChar, bool hasNumbers, bool hasUppercase, bool hasLowercase)
        {
            this.length = length;
            this.hasSpecialChar = hasSpecialChar;
            this.hasNumbers = hasNumbers;
            this.hasUppercase = hasUppercase;
            this.hasLowercase = hasLowercase;
        }

        //Methods
        public bool isStrong()
        {
            return length >= 12 && hasSpecialChar && hasNumbers && hasUppercase && hasLowercase;
        }

        public String generatePassword()
        {
            // Placeholder for password generation logic
            return "GeneratedPassword123!";
        }

        public override string ToString()
        {
            return $"Password Length: {length}, Special Characters: {hasSpecialChar}, Numbers: {hasNumbers}, Uppercase: {hasUppercase}, Lowercase: {hasLowercase}";
        }

    }
    
}