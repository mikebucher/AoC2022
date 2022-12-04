string[] lines = File.ReadAllLines(@"../../../input.txt");
int result = 0;

foreach (var line in lines)
{
    var assignments = line.Split(',');
    var elf1 = Array.ConvertAll(assignments[0].Split('-'), int.Parse);
    var elf2 = Array.ConvertAll(assignments[1].Split('-'), int.Parse);
    
    if (elf1[1] >= elf2[0] &&
        elf1[0] <= elf2[0] ||
        elf2[1] >= elf1[0] &&
        elf2[0] <= elf1[0]) result++;
}

Console.WriteLine($"Result Part1: {result}");