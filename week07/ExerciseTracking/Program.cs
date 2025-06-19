using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2020, 1, 10), 27, 4.1),
            new Cycling(new DateTime(2020, 1, 11), 45, 20.0),
            new Swimming(new DateTime(2020, 1, 12), 33, 41)
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}