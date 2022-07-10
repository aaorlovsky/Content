var collection = Console.ReadLine()!.Split(' ').Select(item => int.Parse(item));
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
        IList<int> friendsOfFriends = new List<int>();
        foreach (var friend in dict[i + 1])
        {
            foreach (var friendOfFriend in dict[friend])
            {
                if (!dict[i + 1].Contains(friendOfFriend) && friendOfFriend != (i + 1))
                {
                    friendsOfFriends.Add(friendOfFriend);
                }
            }
        }
        if (friendsOfFriends.Count() > 0)
        {
            var maxCount = friendsOfFriends.GroupBy(item => item).OrderByDescending(gr => gr.Count()).ThenBy(gr => gr.Key);
            var maxValue = maxCount.First().Count();
            foreach (var max in maxCount)
            {
                if (max.Count() == maxValue)
                {
                    Console.Write(max.Key + " ");
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("0");
        }

    }

}

