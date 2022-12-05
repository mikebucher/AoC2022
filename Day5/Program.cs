string[] lines = File.ReadAllLines(@"../../../input.txt");

char[][] stackArray = new char[9][];

stackArray[0] = new[] {'N', 'C', 'R', 'T', 'M', 'Z', 'P'};
stackArray[1] = new[] {'D', 'N', 'T', 'S', 'B', 'Z'};
stackArray[2] = new[] {'M', 'H', 'Q', 'R', 'F', 'C', 'T', 'G'};
stackArray[3] = new[] {'G', 'R', 'Z'};
stackArray[4] = new[] {'Z', 'N', 'R', 'H'};
stackArray[5] = new[] {'F', 'H', 'S', 'W', 'P', 'Z', 'L', 'D'};
stackArray[6] = new[] {'W', 'D', 'Z', 'R', 'C', 'G', 'M'};
stackArray[7] = new[] {'S', 'J', 'F', 'L', 'H', 'W', 'Z', 'Q'};
stackArray[8] = new[] {'S', 'Q', 'P', 'W', 'N'};

for (int i = 10; i < lines.Length; i++)
{
    var split = lines[i].Split(' ');

    int[] ints = { Convert.ToInt32(split[1]), Convert.ToInt32(split[3]), Convert.ToInt32(split[5]) };

    for (int j = Convert.ToInt32(split[1]); j > 0; j--)
    {
        var toBeMoved = stackArray[ints[1]-1][stackArray[ints[1]-1].Length-j];
        stackArray[ints[2]-1] = stackArray[ints[2]-1].Append(toBeMoved).ToArray();
    }

    stackArray[ints[1]-1] = stackArray[ints[1]-1].SkipLast(ints[0]).ToArray();
}
Console.WriteLine($"{stackArray[0][stackArray[0].Length-1]}{stackArray[1][stackArray[1].Length-1]}{stackArray[2][stackArray[2].Length-1]}{stackArray[3][stackArray[3].Length-1]}{stackArray[4][stackArray[4].Length-1]}{stackArray[5][stackArray[5].Length-1]}{stackArray[6][stackArray[6].Length-1]}{stackArray[7][stackArray[7].Length-1]}{stackArray[8][stackArray[8].Length-1]}");