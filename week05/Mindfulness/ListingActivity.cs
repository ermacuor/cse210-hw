class ListingActivity : Activity
{
    private string[] Prompts = {
        "Who are the people you value?",
        "What are your personal strengths?",
        "Who did you help this week?",
        "When did you feel the Holy Spirit this month?",
        "Who are your personal heroes?"
    };

    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.") { }

    protected override void Execute()
    {
        Random random = new Random();
        Console.WriteLine("List as many response you can to the following prompt:");
        Console.WriteLine("---- " + Prompts[random.Next(Prompts.Length)] + " ----");
        Console.Write("You may begin in:");
        ShowCountDown(5);
        Console.WriteLine();
        
        int remainingTime = Duration;
        List<string> items = new List<string>();

        while (remainingTime > 0)
        {
            Console.Write("> ");
            items.Add(Console.ReadLine());
            remainingTime -= 5;
        }

        Console.WriteLine("You listed " + items.Count + " items\n");
    }
}

