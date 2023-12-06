string[] input = File.ReadAllLines("C:\\Users\\lziel\\source\\repos\\AdwentOfCoding\\DayOnePartTwo\\input.txt");


/// <summary>
/// Replaces all digit string substrings into their integer counterpart. 
/// </summary>
static string ParseSpelledOutDigits(string line)
{
    string[] digitsAsStrings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
    string[] replacements = { "z0o", "o1e", "t2o", "t3e", "f4r", "f5e", "s6x", "s7n", "e8t", "n9e" };

    string newString = "";

    foreach (var character in line.ToCharArray())
    {
        newString += character;

        string? presentDigitString = digitsAsStrings.FirstOrDefault(newString.Contains);

        if (presentDigitString is not null)
        {
            int replacementIndex = digitsAsStrings
                .ToList()
                .IndexOf(presentDigitString);
            newString = newString.Replace(presentDigitString, replacements[replacementIndex]);
        }
    }

    return newString;
}

/// <summary>
/// Iterates through each character, forms a tuple of the first and last digits in the line, and then conjoins the digits
/// into a two-digit number.
/// </summary>
/// <example>
/// ProcessLine("pqr3stu8vwx") -> 38
/// </example>
static int ProcessLine(string newString)
{
   List<int> digit = new List<int>();
   foreach (var character in newString)
    {
        if(int.TryParse(character.ToString(), out int number))
        {
            digit.Add(number);
        }
    }
   int result = int.Parse($"{digit.First()}{digit.Last()}");
    return result;
}
int result = 0;
foreach (var line in input)
{
    
    string newString = ParseSpelledOutDigits(line);
    
    result += ProcessLine(newString);
    

}
Console.WriteLine("Wynik: " + result);