using System.Text.RegularExpressions;

class Part1
{
    public static void GetAnswer(string input)
    {
        var pattern = @"mul\((\d+),(\d+)\)";
        var matches = Regex.Matches(input, pattern);

        int sum = 0;

        foreach (Match match in matches)
        {
            sum += int.Parse(match.Groups[1].Value) * int.Parse(match.Groups[2].Value);
        }

        Console.WriteLine(sum);
    }
}