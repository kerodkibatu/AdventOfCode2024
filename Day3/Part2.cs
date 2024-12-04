using System.Text.RegularExpressions;

class Part2
{
    public static void GetAnswer(string input)
    {
        var pattern = @"mul\((\d+),(\d+)\)|do(n't)?\(\)";
        var matches = Regex.Matches(input, pattern);

        int sum = 0;
        bool adding = true;
        foreach (Match match in matches)
        {
            if (match.Value == "do()")
            {
                adding = true;
                continue;
            }
            else if (match.Value == "don't()")
            {
                adding = false;
                continue;
            }
            if (adding)
                sum += int.Parse(match.Groups[1].Value) * int.Parse(match.Groups[2].Value);
        }

        Console.WriteLine(sum);
    }
}