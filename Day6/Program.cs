var lines = File.ReadAllLines(@"../../../input.txt");
var input = lines[0];
var found = false;

for (int i = 0; i < input.Length-14; i++)
{
    List<char> lettersChecked = new List<char>
    {
        input[i],
        input[i+1],
        input[i+2],
        input[i+3],
        input[i+4],
        input[i+5],
        input[i+6],
        input[i+7],
        input[i+8],
        input[i+9],
        input[i+10],
        input[i+11],
        input[i+12],
        input[i+13]
    };

    var result = lettersChecked.Distinct();

    if (result.Count() == 14 && !found)
    {
        Console.WriteLine($"Part1: {i+14}");
        found = true;
    }
}