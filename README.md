# ToPseudoLocale
A single extension method for string to change it from English to a pseudo language. 

## What can it be used for?
It can be used to translate any text into a pseudo locale form in order for localisation testing.

## Pseudo Alphabet

    àÀ  ьß  çÇ  ðÐ  êË  ʄƑ  ĝĜ  ħĦ  íÍ  ĵĴ  ƙƘ  լԼ  ᵯϺ  иÑ  õÖ  þƤ  ¶Ф  яЯ  šŠ  ťŦ  µÛ  ᵿƔ  щЩ  жЖ  ÿÝ  žŽ
	
## Example

    using ToPseudoLocale;
	
    namespace Translate
    {
        public class Program
        {
            public static void Main(string[] args)
            {
                string pseudo = "String to translate.".ToPseudo();
            }
        }
    }
	
pseudo: [ Šťяíиĝ ťõ ťяàиšլàťê. !!!! ]

## Nuget install

    Install-Package ToPseudoLocale 
