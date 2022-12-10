var lines = File.ReadAllLines(@"../../../input.txt");
var cycle = 0;
var x = 1;
var crt = new char[240];

foreach (var t in lines)
{
    var split = t.Split(' ');
    switch (split[0])
    {
        case "noop":
            cycle++;
            CheckForRelevantCycle();
            break;
        case "addx":
            cycle++;
            CheckForRelevantCycle();
            cycle++;
            CheckForRelevantCycle();
            x += Convert.ToInt32(split[1]);
            break;
    }
}

Console.WriteLine($"{new string(crt)}");

void CheckForRelevantCycle()
{
    if (cycle % 40 -1 >= x - 1 && cycle % 40 -1 <= x + 1)
    {
        crt[cycle-1] = '#';
    }
    else
    {
        crt[cycle-1] = '.';
    }
}