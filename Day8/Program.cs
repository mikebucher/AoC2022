var lines = File.ReadAllLines(@"../../../input.txt");
var result1 = 0;
var result2 = 0;

var input = new int[lines.Length][];

for (var i = 0; i < lines.Length; i++)
{
    input[i] = lines[i].Select(c => Convert.ToInt32(c) - '0').ToArray();
}

for (var y = 0; y < 99; y++)
{
    for (var x = 0; x < 99; x++)
    {
        if (CheckEast(x, y, input) || CheckNorth(x, y, input) || CheckSouth(x, y, input) || CheckWest(x, y, input)) result1++;
        int treeScore = CheckScoreEast(x, y, input) * CheckScoreNorth(x, y, input) *
                        CheckScoreSouth(x, y, input) * CheckScoreWest(x, y, input);
        if (treeScore > result2) result2 = treeScore;
    }
}

Console.WriteLine($"Part1: {result1}");
Console.WriteLine($"Part2: {result2}");

bool CheckNorth(int x, int y, int[][] grid)
{
    var tree = grid[y][x];
    for (var i = y-1; i >= 0; i--)
    {
        if (grid[i][x] >= tree) return false;
    }
    return true;
}
bool CheckEast(int x, int y, int[][] grid)
{
    var tree = grid[y][x];
    for (var i = x+1; i < 99; i++)
    {
        if (grid[y][i] >= tree) return false;
    }
    return true;
}
bool CheckSouth(int x, int y, int[][] grid)
{
    var tree = grid[y][x];
    for (var i = y+1; i < 99; i++)
    {
        if (grid[i][x] >= tree) return false;
    }
    return true;
}
bool CheckWest(int x, int y, int[][] grid)
{
    var tree = grid[y][x];
    for (var i = x-1; i >= 0; i--)
    {
        if (grid[y][i] >= tree) return false;
    }
    return true;
}
int CheckScoreNorth(int x, int y, int[][] grid)
{
    var tree = grid[y][x];
    var score = 0;
    for (var i = y-1; i >= 0; i--)
    {
        score++;
        if (grid[i][x] >= tree) return score;
    }
    return score;
}
int CheckScoreEast(int x, int y, int[][] grid)
{
    var tree = grid[y][x];
    var score = 0;
    for (var i = x+1; i < 99; i++)
    {
        score++;
        if (grid[y][i] >= tree) return score;
    }
    return score;
}
int CheckScoreSouth(int x, int y, int[][] grid)
{
    var tree = grid[y][x];
    var score = 0;
    for (var i = y+1; i < 99; i++)
    {
        score++;
        if (grid[i][x] >= tree) return score;
    }
    return score;
}
int CheckScoreWest(int x, int y, int[][] grid)
{
    var tree = grid[y][x];
    var score = 0;
    for (var i = x-1; i >= 0; i--)
    {
        score++;
        if (grid[y][i] >= tree) return score;
    }
    return score;
}