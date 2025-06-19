class Activity
{
    protected string Name;
    protected string Description;
    protected int Duration;

    public Activity(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public void Start()
    {
        Console.Clear();
        Console.WriteLine("Welcome to the " + Name + "activity");
        Console.WriteLine(Description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session?");
        Duration = int.Parse(Console.ReadLine());
        Console.Clear();

        Console.WriteLine("Get ready...");
        ShowSpinner(3);
        Execute();
        End();
        LogActivity(Name);
    }

    protected virtual void Execute() { }

    public void End()
    {
        Console.WriteLine("Well done!!");
        ShowSpinner(3);
        Console.WriteLine();
        Console.WriteLine("you have completed another " + Duration + " segundos of the " + Name + " activity");
        ShowSpinner(3);
    }

    public void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    private void LogActivity(string activityName)
    {
        string logFile = "activity_log.txt";
        List<string> activityCount = new List<string>();

        if (File.Exists(logFile))
        {
            activityCount.AddRange(File.ReadAllLines(logFile));
        }

        activityCount.Add(activityName);
        File.WriteAllLines(logFile, activityCount);
    }
}

