string[] fileRaw = [.. File.ReadLines("input.txt")];

List<int> As = [];
List<int> Bs = [];

string process(string line)
{
    return line.Replace("   ", " ");
}


foreach (var line in fileRaw)
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