string[] lines = File.ReadAllLines(@"../../../input.txt");
int result = 0;

for (int i = 0; i < lines.Length; i+=3)
{
    List<char> temp = new List<char>();
    foreach (char c in lines[i])
    {
        if (lines[i+1].Contains(c) && lines[i+2].Contains(c) && !temp.Contains(c))
        {
            result += c % 32;
            if (Char.IsUpper(c)) result += 26;
            temp.Add(c);
        }
    }
}

Console.WriteLine($"Result Part2: {result}");