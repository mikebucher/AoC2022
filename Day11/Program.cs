using System.Numerics;

var lines = File.ReadAllLines(@"../../../input.txt");

var monkey0 = new List<BigInteger>() {65, 58, 93, 57, 66};
var monkey1 = new List<BigInteger>() {76, 97, 58, 72, 57, 92, 82};
var monkey2 = new List<BigInteger>() {90, 89, 96};
var monkey3 = new List<BigInteger>() {72, 63, 72, 99};
var monkey4 = new List<BigInteger>() {65};
var monkey5 = new List<BigInteger>() {97, 71};
var monkey6 = new List<BigInteger>() {83, 68, 88, 55, 87, 67};
var monkey7 = new List<BigInteger>() {64, 81, 50, 96, 82, 53, 62, 92};

var count0 = 0;
var count1 = 0;
var count2 = 0;
var count3 = 0;
var count4 = 0;
var count5 = 0;
var count6 = 0;
var count7 = 0;

for (int i = 0; i < 10000; i++)
{
    if(i == 9999) Console.WriteLine("bla");
    foreach (var item in monkey0)
    {
        var newworry = item * 7;
        count0++;
        if(newworry % 19 == 0) monkey6.Add(newworry);
        else monkey4.Add(newworry);
    }
    monkey0 = new List<BigInteger>();
    foreach (var item in monkey1)
    {
        var newworry = item + 4;
        count1++;
        if(newworry % 3 == 0) monkey7.Add(newworry);
        else monkey5.Add(newworry);
    }
    monkey1 = new List<BigInteger>();
    foreach (var item in monkey2)
    {
        var newworry = item * 5;
        newworry %= 9699690;
        count2++;
        if(newworry % 13 == 0) monkey5.Add(newworry);
        else monkey1.Add(newworry);
    }
    monkey2 = new List<BigInteger>();
    foreach (var item in monkey3)
    {
        var newworry = item * item;
        newworry %= 9699690;
        count3++;
        if(newworry % 17 == 0) monkey0.Add(newworry);
        else monkey4.Add(newworry);
    }
    monkey3 = new List<BigInteger>();
    foreach (var item in monkey4)
    {
        var newworry = item + 1;
        newworry %= 9699690;
        count4++;
        if(newworry % 2 == 0) monkey6.Add(newworry);
        else monkey2.Add(newworry);
    }
    monkey4 = new List<BigInteger>();
    foreach (var item in monkey5)
    {
        var newworry = item + 8;
        newworry %= 9699690;
        count5++;
        if(newworry % 11 == 0) monkey7.Add(newworry);
        else monkey3.Add(newworry);
    }
    monkey5 = new List<BigInteger>();
    foreach (var item in monkey6)
    {
        var newworry = item + 2;
        newworry %= 9699690;
        count6++;
        if(newworry % 5 == 0) monkey2.Add(newworry);
        else monkey1.Add(newworry);
    }
    monkey6 = new List<BigInteger>();
    foreach (var item in monkey7)
    {
        var newworry = item + 5;
        newworry %= 9699690;
        count7++;
        if(newworry % 7 == 0) monkey3.Add(newworry);
        else monkey0.Add(newworry);
    }
    monkey7 = new List<BigInteger>();
}

Console.WriteLine($"{count0} {count1} {count2} {count3} {count4} {count5} {count6} {count7}  ");