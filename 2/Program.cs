var numberOfSets = int.Parse(Console.ReadLine()!);

for (var i = 0; i < numberOfSets; i++)
{
    Dictionary<int, int> devsDic = new Dictionary<int, int>();
    var numberOfDevs = int.Parse(Console.ReadLine()!);
    var devsLevels = Console.ReadLine()!.Split(' ').Select(el => int.Parse(el)).ToArray();

    for (var j = 0; j < numberOfDevs; j++)
    {
        devsDic.Add(j + 1, devsLevels[j]);
    }

    while (devsDic.Count() != 0)
    {
        var devFirst = devsDic.First();
        devsDic.Remove(devFirst.Key);
        var secondDev = devsDic.MinBy(item => Math.Abs(item.Value - devFirst.Value)).Key;
        Console.WriteLine($"{devFirst.Key} {secondDev}");
        devsDic.Remove(secondDev);
    }

    Console.WriteLine();
}
