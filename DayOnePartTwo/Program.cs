using DayOnePartTwo;

string fileTextPath = "C:\\\\Users\\\\lziel\\\\source\\\\repos\\\\AdwentOfCoding\\\\DayOnePartTwo\\\\xeoInput.txt";
string exampleText = "C:\\Users\\lziel\\source\\repos\\AdwentOfCoding\\DayOnePartTwo\\example.txt";
List<string> inputText = File.ReadAllLines(fileTextPath).ToList();

int result = Methods.CalculateResult(inputText);
Console.WriteLine("Wynik: " + result);
