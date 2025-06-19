using System.Diagnostics;

class ReflectingActivity : Activity
{
    private string[] Prompts = {
        "Think of a time when you stood up for someone.",
        "Think of a difficult situation you overcame.",
        "Think about a time you helped someone in need.",
        "Think of a time when you did something completely selfless."
    };

    private string[] Questions = {
        "Why was this experience meaningful to you?",
        "Have you done something similar before?",
        "How did you get started?",
        "How did you feel after completing it?",
        "What makes this occasion different from others?",
        "What is your favorite part of this experience?",
        "What could you learn from this experience?",
        "What did you learn about yourself?",
        "How can you apply this in the future?"
    };

    public ReflectingActivity() : base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.") { }

    protected override void Execute()
    {
        Console.WriteLine("Consider the following prompt:");
        Random random = new Random();
        Console.WriteLine("---- " + Prompts[random.Next(Prompts.Length)]+ " ----\n");
        Console.Write("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("\nNow ponder on each of the following quiestions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(8);
        Console.Clear();

        int remainingTime = Duration;
        while (remainingTime > 0)
        {
            Console.Write("> " + Questions[random.Next(Questions.Length)]);
            ShowSpinner(10);
            Console.WriteLine();
            remainingTime -= 5;
        }
    }
}
