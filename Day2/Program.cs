string[] lines = File.ReadAllLines(@"../../../input.txt");
int result = 0;

foreach (var line in lines)
{
    var split = line.Split(" ");
    switch (split[0])
    {
        case "A":
            switch (split[1])
            {
                case "X":
                    result += 3;
                    break;
                case "Y":
                    result += 4;
                    break;
                case "Z":
                    result += 8;
                    break;
            }
            break;
        case "B":
            switch (split[1])
            {
                case "X":
                    result += 1;
                    break;
                case "Y":
                    result += 5;
                    break;
                case "Z":
                    result += 9;
                    break;
            }
            break;
        case "C":
            switch (split[1])
            {
                case "X":
                    result += 2;
                    break;
                case "Y":
                    result += 6;
                    break;
                case "Z":
                    result += 7;
                    break;
            }
            break;
    }
}

Console.WriteLine($"Result: {result}");