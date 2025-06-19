class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.") { }

    protected override void Execute()
    {
        int remainingTime = Duration;
        while (remainingTime > 0)
        {
            Console.Write("Breathe in...");
            ShowCountDown(4);
            Console.WriteLine();
            remainingTime -= 4;

            if (remainingTime <= 0) break;

            Console.Write("now Brethe out...");
            ShowCountDown(6);
            Console.WriteLine("\n");
            remainingTime -= 6;
        }
    }
}

