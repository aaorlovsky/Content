var numberOfSets = int.Parse(Console.ReadLine()!);

for (var i = 0; i < numberOfSets; i++)
{
    var numberOfPeriods = int.Parse(Console.ReadLine()!);
    double periodStart = DateTime.Now.TimeOfDay.TotalSeconds;
    double periodFinish = DateTime.Now.TimeOfDay.TotalSeconds;
    var correct = true;
    Dictionary<double, double> periodSet = new Dictionary<double, double>();

    for (var j = 0; j < numberOfPeriods; j++)
    {

        try
        {
            if (correct)
            {
                var period = Console.ReadLine()!.Split('-').Select(item => DateTime.ParseExact(item, "HH:mm:ss", null).TimeOfDay.TotalSeconds);

                var startTime = period.First();
                var finishTime = period.Last();

                if (startTime > finishTime)
                {
                    Console.WriteLine("NO");
                    correct = false;
                }

                if (periodSet.ContainsKey(startTime))
                {
                    Console.WriteLine("NO");
                    correct = false;
                }
                else
                {
                    periodSet.Add(startTime, finishTime);
                }
            }
            else
            {
                var period = Console.ReadLine()!;
            }
        }
        catch
        {
            Console.WriteLine("NO");
            correct = false;
        }
    }

    if (correct)
    {
        var number = 0;
        double finish = 0;
        foreach (KeyValuePair<double, double> period in periodSet.OrderBy(item => item.Key))
        {
            if (number == 0)
            {
                finish = period.Value;
            }
            else
            {
                if (period.Key <= finish)
                {
                    Console.WriteLine("NO");
                    correct = false;
                    break;
                }
                finish = period.Value;
            }
            number++;
        }
        if (correct)
        {
            Console.WriteLine("YES");
        }
    }
}
