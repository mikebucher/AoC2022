var lines = File.ReadAllLines(@"../../../input.txt");
var input = lines[0];
var found = false;

for (var i = 0; i < input.Length-14; i++)
{
    var lettersChecked = new HashSet<char>();
    for(var j=0; j<14; j++){
        lettersChecked.Add(input[i+j]);
    }

    if (lettersChecked.Count() == 14 && !found)
    {
        Console.WriteLine($"Result: {i+14}");
        found = true;
    }
}