using Day2;

string[] filePath = File.ReadAllLines("C:\\Users\\lziel\\source\\repos\\AdwentOfCoding\\Day2\\input.txt");
string[] example = File.ReadAllLines("C:\\Users\\lziel\\source\\repos\\AdwentOfCoding\\Day2\\example.txt");

//Methods.CheckGame(example[0]);
int result = 0;
foreach (var line in filePath)
{
    result += Methods.Day2Part2(line);
}
Console.WriteLine("WYNIK: " + result);
//Methods.Day2Part2(example[0]);

