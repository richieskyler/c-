using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HelloWorld
{
    class PasswordChecker
    {
        public  bool ContainsSpecialCharacter(string password)
        {
            // This regular expression checks for the presence of at least one special character.
            string specialCharacterPattern = @"[!@#$%^&*()_+\-=\[\]{};':""\\|,.<>\/?]";
            return Regex.IsMatch(password, specialCharacterPattern);
        }
    }
}
