                                                        //Regular Expression Cheat Sheet
/*
 * ^ - Starts with
 * $ - Ends with
 * [] - Range
 * () - Group
 * . - Single character once
 * + - One or more characters in a row
 * ? - optional preceding character match
 * \ - escape character
 * \n - New line
 * \d - Digit
 * \D - Non-digit
 * \s - White space
 * \S - non-white space
 * \w - alpaneumerical/underscore character (word chars)
 * \W - non-word characters
 * {x,y} - Repeat low (x to high (y) (no "y" means atleast x, no",y" means that many)
 * (x|y) - Alternative - x or y
 * [^x] - Anything but x (where x is whatever character you want)
 */
                                                        //Regex Sample Code while using my First & Last name

using System.Text.RegularExpressions; //Standard library for Pattern matching
        //string pattern = "[Tt]homas";
        //When using range

        //string pattern = @"\s[Tt]homas\s";
        //string literal to indicate no escape characters with white space preceding and succeeding first name

        //string pattern = @"(\s|^)[Tt]homas\s";
        //string literal, Uses Alternative to indicate whether name starts wit space or T/t

        //String pattern = @"Thomas(/s|$)";
        //string literal, Uses Alternative to indicate is ends with first name and either a space or no space

//Above commands commented out; Sample Regular Expressions commonly used for searching for or manipulating data

string pattern = "Thomas";//Standard alphasnumeric characters to be replaced with Regex with above commands
Console.WriteLine(format: "Thomas Speer " + Regex.IsMatch(input: "Thomas Speer", pattern, RegexOptions.IgnoreCase));//Commands such as Ignore case are useful possibilities but not preferred when working with the data
Console.WriteLine(format: "Thomas Speer " + Regex.IsMatch(input: "Thomas Speer", pattern));
Console.WriteLine(format: "T Speer " + Regex.IsMatch(input: "T Speer", pattern));
Console.WriteLine(format: "thomas " + Regex.IsMatch(input: "thomas ", pattern));
Console.WriteLine(format: "thomas Speer " + Regex.IsMatch(input: "thomas Speer", pattern));
Console.WriteLine(format: " Thomas Speer " + Regex.IsMatch(input: " Thomas Speer ", pattern));
Console.WriteLine(format: "Speer Thomas" + Regex.IsMatch(input: "Speer Thomas", pattern));
//Duplicates used to analyze differences in data when implementing Regex commands
//When using static it remembers cached compiled patterns for up to 15 patterns