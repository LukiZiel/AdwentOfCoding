using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day2
{
    public static class Methods
    {
        static Dictionary<string, int> blockerValues = new Dictionary<string, int>()
        {
            {"red", 12 },
            {"green", 13 },
            {"blue", 14 }
        };
        public static int CheckGame(string line)
        {
            Console.WriteLine("********Zadana Linia *********: " + line);
            char[] separators = { ':', ';' };
            List<string> splitedLine = line.Split(separators).ToList();
            string gameId = splitedLine[0];
            Match iDmatch = Regex.Match(gameId, @"\d+");
            splitedLine.RemoveAt(0);
            Console.WriteLine("&&&&&&&&&&&&&&&&&& IDMatch &&&&&&&&&&&&&&&&&&&&&: " + iDmatch);
            foreach (var item in splitedLine)
            {
                var splitedItem = item.Split(',');
                splitedItem.ToList().ForEach(x => Console.WriteLine("Pary:" + x));

                foreach (var x in splitedItem)
                {
                    Dictionary<string, int> cubeColor = new Dictionary<string, int>();
                    var match = Regex.Match(x, @"\d+");                                  
                    int digit = int.Parse(match.ToString());
                    string cubeName = x.TrimStart().Split(' ')[1];
                    Console.WriteLine("Kolor: " + cubeName);
                    cubeColor.Add(cubeName, digit);
                    foreach(var y in cubeColor)
                    {
                        Console.WriteLine($"Klucz: {y.Key}\nWartosc: {y.Value}");
                    }
                    foreach (var key in blockerValues)
                    {
                        if (cubeColor.TryGetValue(key.Key, out int value2) && key.Value < value2)
                        {
                            Console.WriteLine("Nie spełnia warunków");
                            Console.WriteLine("--------------------------------------------");
                            return 0;
                            
                        }
                    }

                }

            }
            Console.WriteLine("@@@@@@@@@ID@@@@@@@@: " + iDmatch);
            Console.WriteLine("-----------------------------------");
            return int.Parse(iDmatch.ToString());
        }

        public static int Day2Part2(string line)
        {
            Console.WriteLine("********Zadana Linia *********: " + line);
            char[] separators = { ':', ';' };
            List<string> splitedLine = line.Split(separators).ToList();
            splitedLine.RemoveAt(0);
            splitedLine.ToList().ForEach(x => Console.WriteLine(x));
            Dictionary<string, int> maxValues = new Dictionary<string, int>();
            foreach (var games in splitedLine)
            {
                var colorAndNumber = games.TrimStart().Split(',');
                foreach (var item in colorAndNumber)
                {
                    var count = int.Parse(item.TrimStart().Split(" ")[0]);
                    var color = item.TrimStart().Split(" ")[1];
                    Console.WriteLine("count: " + count + "\nColor: "+ color);
                    if (!maxValues.ContainsKey(color) || count > maxValues[color])
                    {
                        maxValues[color] = count;
                    }
                }                
                
            }
            int product = maxValues.Values.Aggregate(1, (x, value) => x * value);
            Console.WriteLine("wynik: " +  product);
            return product;
        }
    }
}
