class Part1
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

        As = [.. As.Order()];
        Bs = [.. Bs.Order()];


        List<Pair> pairs = [];

        for (int i = 0; i < As.Count; i++)
        {
            pairs.Add(new(As[i], Bs[i]));
        }

        int distanceSum = pairs.Sum(p => p.Distance);

        Console.WriteLine(distanceSum);
    }
    class Pair(int x, int y)
    {
        public int Distance => Math.Abs(x - y);
    }
}