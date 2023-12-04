namespace DayOnePartTwo;
public static class Methods
{
    
    public static int ExtractDigit(string inputText)
    {
        Dictionary<string, int> numbers = new Dictionary<string, int>();
        numbers.Add("zero", 0);
        numbers.Add("one", 1);
        numbers.Add("two", 2);
        numbers.Add("three", 3);
        numbers.Add("four", 4);
        numbers.Add("five", 5);
        numbers.Add("six", 6);
        numbers.Add("seven", 7);
        numbers.Add("eight", 8);
        numbers.Add("nine", 9);

        List<int> numbersList = new List<int>();
        string temp = "";
        foreach (var letter in inputText)
        {
            temp += letter;
            foreach (var keyNum in numbers.Keys)
            {
                if (temp.Contains(keyNum))
                {
                    temp = temp.Replace(keyNum.ToString(), numbers[keyNum].ToString());
                }
            }
        }
        foreach (var letter in temp)
        {
            if (int.TryParse(letter.ToString(), out int r))
            {
                numbersList.Add(r);
            }
        }

        string tempStr = numbersList.First().ToString() + numbersList.Last().ToString();
        return int.Parse(tempStr);
    }

    public static int CalculateResult(List<string> list)
    {
        int result = 0;
        foreach (var line in list)
        {
            result += ExtractDigit(line);
        }
        return result;       
    }
}
