var lines = File.ReadAllLines(@"../../../input.txt");

var stackArray = new char[9][];

stackArray[0] = new[] {'N', 'C', 'R', 'T', 'M', 'Z', 'P'};
stackArray[1] = new[] {'D', 'N', 'T', 'S', 'B', 'Z'};
stackArray[2] = new[] {'M', 'H', 'Q', 'R', 'F', 'C', 'T', 'G'};
stackArray[3] = new[] {'G', 'R', 'Z'};
stackArray[4] = new[] {'Z', 'N', 'R', 'H'};
stackArray[5] = new[] {'F', 'H', 'S', 'W', 'P', 'Z', 'L', 'D'};
stackArray[6] = new[] {'W', 'D', 'Z', 'R', 'C', 'G', 'M'};
stackArray[7] = new[] {'S', 'J', 'F', 'L', 'H', 'W', 'Z', 'Q'};
stackArray[8] = new[] {'S', 'Q', 'P', 'W', 'N'};

for (var i = 10; i < lines.Length; i++)
{
    var split = lines[i].Split(' ');

    var stack = Convert.ToInt32(split[1]);
    var from = Convert.ToInt32(split[3]);
    var to = Convert.ToInt32(split[5]) ;

    for (var j = stack; j > 0; j--)
    {
        var indexToBeMoved = stackArray[from - 1].Length - j;
        var toBeMoved = stackArray[from-1][indexToBeMoved];
        stackArray[to-1] = stackArray[to-1].Append(toBeMoved).ToArray();
    }

    stackArray[from-1] = stackArray[from-1].SkipLast(stack).ToArray();
}

Console.WriteLine($"{string.Join("", stackArray.Select(x => x.Last()))}");