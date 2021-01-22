// Skriv en metod med namnet IsPalindrome som tar en char array
// parameter och returnerar en bool. Om tecknen i char
// array-argumentet bildar ett palindrom, d.v.s. ett ord som har
// samma betydelse vare sig vi läser ordet framlänges eller
// baklänges (ex. NaturrutaN, RadaR, AbadabA, etc.) så ska
// metoden returnera true och i annat fall false. Använda inte
// den statiska metoden Array.Reverse() för att implementera
// metoden IsPalindrome.
//string s = "Naturrutan";
//if (IsPalindrome(s.ToLower().ToCharArray()))
//    Console.WriteLine($"Ordet \"{s}\" är ett palindrom.");
//else
//    Console.WriteLine($"Ordet \"{s}\" är inte ett palindrom.");


using System;

namespace ArrayExersicePalindrome
{
    class ProgramPalindrome
    {
        static string word = "";
        static string revWord = "";
        static void Main(string[] args)
        {
            if (IsPalindrome("natan".ToLower().ToCharArray()))
                Console.WriteLine($"\"{word}\" is a palindrome - wohoo!");
            else
                Console.WriteLine($"There is nothing cool about \"{word}\".");
            //IsPalindrome(new char[] {'n','a','t','a','n'});
        }

        private static bool IsPalindrome(char[] letters)
        {
            for (int i = 0; i < letters.Length; i++)
            {
                word += letters[i];
            }

            for (int i = letters.Length - 1; i >= 0; i--)
            {
                revWord += letters[i];
            }

            if (word == revWord)
                return true;
            else
                return false;
        }
    }
}
