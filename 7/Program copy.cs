/*var collection = Console.ReadLine()!.Split(' ').Select(item => int.Parse(item));
var numberOfUsers = collection.First();
var numberOfPairs = collection.Last();

Dictionary<int, HashSet<int>> dict = new Dictionary<int, HashSet<int>>();

for (var i = 0; i < numberOfPairs; i++)
{
    collection = Console.ReadLine()!.Split(' ').Select(item => int.Parse(item));
    var user_1 = collection.First();
    var user_2 = collection.Last();
    if (!dict.ContainsKey(user_1))
    {
        dict.Add(user_1, new HashSet<int> { user_2 });
    }
    else
    {
        dict[user_1].Add(user_2);
    }
    if (!dict.ContainsKey(user_2))
    {
        dict.Add(user_2, new HashSet<int> { user_1 });
    }
    else
    {
        dict[user_2].Add(user_1);
    }
}


for (var i = 0; i < numberOfUsers; i++)
{
    if (!dict.ContainsKey(i + 1))
    {
        Console.WriteLine("0");
    }
    else
    {
        HashSet<int> friends = dict[i + 1];
        var dictForChoose = dict.Where(item => item.Key != i + 1 && !friends.Contains(item.Key) && item.Value.Any(it => friends.Contains(it)))
                                .ToLookup(x => x.Value.Intersect(friends).Count(), x => x.Key);

        if (dictForChoose.Count() > 0)
        {
            foreach (int result in dictForChoose.OrderByDescending(item => item.Key).First().OrderBy(item => item))
            {
                Console.Write(result + " ");
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("0");
        }
    }

}*/

