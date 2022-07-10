var collection = Console.ReadLine()!.Split(' ').Select(item => int.Parse(item)).ToArray();
int[] allMessage = new int[collection.First()];
//int[] allMessage = new int[collection.First()];
var messageNumber = 0;
var massSender = 0;

for (var i = 0; i < collection.Last(); i++)
{
    var query = Console.ReadLine()!.Split(' ').Select(item => int.Parse(item)).ToArray();

    if (query.First() == 1)
    {
        messageNumber++;
        if (query.Last() > 0)
        {
            allMessage[query.Last() - 1] = messageNumber;
        }
        else
        {
            massSender = messageNumber;
        }
    }
    else
    {
        if (massSender > allMessage[query.Last() - 1])
            Console.WriteLine(massSender);
        else
            Console.WriteLine(allMessage[query.Last() - 1]);
    }
}
