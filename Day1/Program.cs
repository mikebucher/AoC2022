string[] lines = File.ReadAllLines(@"../../../input.txt");
List<int> totalCalories = new List<int>();
var current = 0;

foreach (var line in lines)
{
    if(line != String.Empty) current += Int32.Parse(line);
    else
    {
        totalCalories.Add(current);
        current = 0;
    }
}

var sorted = totalCalories.OrderByDescending(x => x);

var result = sorted.Take(3).Sum();

Console.WriteLine($"Total Calories of Top 3: {result}");