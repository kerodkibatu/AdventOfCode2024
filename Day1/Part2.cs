
//Part1.GetAnswer(input);
class Part2
{
    public static void GetAnswer(string input)
    {
        string[] lines = input.Split('\n');

        List<int> As = [];
        List<int> Bs = [];

        string process(string line)
        {
            return line.Replace("   ", " ");
        }

        foreach (var line in lines)
        {
            int[] Items = [.. process(line).Split(" ").Select(int.Parse)];

            As.Add(Items[0]);
            Bs.Add(Items[1]);
        }

        int SimilarityScore = 0;

        for (int i = 0; i < As.Count; i++)
        {
            int A = As[i];

            int countInB = Bs.Count(B => B == A);

            int similarity = A * countInB;

            SimilarityScore += similarity;
        }

        Console.WriteLine(SimilarityScore);
    }
}
