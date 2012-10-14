using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToPseudoLocale
{
    public static class StringExtensions
    {
        public static string ToPseudo(this string text)
        {
            string translation = "[ ";
            int padding = (int) (text.Length * 0.3) - 2;

            foreach (char letter in text)
            {
                translation += letter.ToPseudo();
            }

            translation += " ";

            for (int i = 0; i < padding; i++)
            {
                translation += "!";
            }

            return translation + " ]";
        }

        public static char ToPseudo(this char letter)
        {
            char character = letter;

            switch (letter)
            {
                case 'a':
                    character = 'à';
                    break;
                case 'A':
                    character = 'À';
                    break;
                case 'b':
                    character = 'ь';
                    break;
                case 'B':
                    character = 'ß';
                    break;
                case 'c':
                    character = 'ç';
                    break;
                case 'C':
                    character = 'Ç';
                    break;
                case 'd':
                    character = 'ð';
                    break;
                case 'D':
                    character = 'Ð';
                    break;
                case 'e':
                    character = 'ê';
                    break;
                case 'E':
                    character = 'Ë';
                    break;
                case 'f':
                    character = 'ʄ';
                    break;
                case 'F':
                    character = 'Ƒ';
                    break;
                case 'g':
                    character = 'ĝ';
                    break;
                case 'G':
                    character = 'Ĝ';
                    break;
                case 'h':
                    character = 'ħ';
                    break;
                case 'H':
                    character = 'Ħ';
                    break;
                case 'i':
                    character = 'í';
                    break;
                case 'I':
                    character = 'Í';
                    break;
                case 'j':
                    character = 'ĵ';
                    break;
                case 'J':
                    character = 'Ĵ';
                    break;
                case 'k':
                    character = 'ƙ';
                    break;
                case 'K':
                    character = 'Ƙ';
                    break;
                case 'l':
                    character = 'լ';
                    break;
                case 'L':
                    character = 'Լ';
                    break;
                case 'm':
                    character = 'ᵯ';
                    break;
                case 'M':
                    character = 'Ϻ';
                    break;
                case 'n':
                    character = 'и';
                    break;
                case 'N':
                    character = 'Ñ';
                    break;
                case 'o':
                    character = 'õ';
                    break;
                case 'O':
                    character = 'Ö';
                    break;
                case 'p':
                    character = 'þ';
                    break;
                case 'P':
                    character = 'Ƥ';
                    break;
                case 'q':
                    character = '¶';
                    break;
                case 'Q':
                    character = 'Ф';
                    break;
                case 'r':
                    character = 'я';
                    break;
                case 'R':
                    character = 'Я';
                    break;
                case 's':
                    character = 'š';
                    break;
                case 'S':
                    character = 'Š';
                    break;
                case 't':
                    character = 'ť';
                    break;
                case 'T':
                    character = 'Ŧ';
                    break;
                case 'u':
                    character = 'µ';
                    break;
                case 'U':
                    character = 'Û';
                    break;
                case 'v':
                    character = 'ᵿ';
                    break;
                case 'V':
                    character = 'Ɣ';
                    break;
                case 'w':
                    character = 'щ';
                    break;
                case 'W':
                    character = 'Щ';
                    break;
                case 'x':
                    character = 'ж';
                    break;
                case 'X':
                    character = 'Ж';
                    break;
                case 'y':
                    character = 'ÿ';
                    break;
                case 'Y':
                    character = 'Ý';
                    break;
                case 'z':
                    character = 'ž';
                    break;
                case 'Z':
                    character = 'Ž';
                    break;
            }

            return character;
        }
    }
}
