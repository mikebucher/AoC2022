var lines = File.ReadAllLines(@"../../../input.txt");
var directories = new Dictionary<string, int>();
var currentDirectoryPath = new LinkedList<string>();
var alreadyCalculatedFolders = new List<string>();

foreach (var line in lines)
{
    var commands = line.Split(' ');

    //command
    if (line.StartsWith("$"))
    {
        if (commands[1] == "cd")
        {
            switch (commands[2])
            {
                case "/":
                    currentDirectoryPath.Clear();
                    break;
                case "..":
                    alreadyCalculatedFolders.Add(string.Join("", currentDirectoryPath));
                    currentDirectoryPath.RemoveLast();
                    break;
                default:
                    currentDirectoryPath.AddLast(commands[2]);
                    break;
            }
        }
        //ls can be ignored
    }
    //directory
    else if (line.StartsWith("dir"))
    {
        string directory = string.Join("", currentDirectoryPath) + commands[1];
        if(!directories.ContainsKey(directory)) directories.Add(directory, 0);
    }
    //must be a file
    else
    {
        if (!alreadyCalculatedFolders.Contains(string.Join("", currentDirectoryPath)))
        {
            for (var i = 0; i < currentDirectoryPath.Count; i++)
            {
                var folders = "";
                for (var j = 0; j <= i; j++)
                {
                    folders += currentDirectoryPath.ElementAt(j);
                }
                directories[folders] += Convert.ToInt32(commands[0]);
            }
        }
    }
}

var result = directories.Where(kvp => kvp.Value <= 100000).Sum(kvp => kvp.Value);

Console.WriteLine($"Part 1: {result}");