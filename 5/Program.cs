var numberOfSets = int.Parse(Console.ReadLine()!);

for (var i = 0; i < numberOfSets; i++)
{
    var numberOfDays = int.Parse(Console.ReadLine()!);
    var collections = Console.ReadLine()!.Split(' ').Select(item => int.Parse(item)).ToArray();

    Dictionary<int, int> tasks = new Dictionary<int, int>();
    var severalTasks = false;

    for (var j = 0; j < numberOfDays; j++)
    {
        if (!tasks.ContainsKey(collections[j]))
        {
            tasks.Add(collections[j], j);
        }
        else
        {
            if ((j - tasks[collections[j]]) > 1)
            {
                Console.WriteLine("NO");
                severalTasks = true;
                break;
            }
            else
            {
                tasks[collections[j]] = j;
            }
        }
    }

    if (!severalTasks)
    {
        Console.WriteLine("YES");
    }
}

